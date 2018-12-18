using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using WindowsCrashDemo.Common;
using WindowsCrashDemo.WinForms.Lib;
using WindowsCrashDemo.WinForms.Lib.Forms;
using Application = System.Windows.Application;

namespace WindowsCrashDemo.ViewModels
{
    public class MainWindowViewModel : Observable
    {

        protected MainWindow MainWindow => (MainWindow) Application.Current.MainWindow;
        
        private FormViewModel _selectedWorkspace;
        public FormViewModel SelectedWorkspace
        {
            get => _selectedWorkspace;
            set => SetField(ref _selectedWorkspace, value);
        }

        private ObservableCollection<FormViewModel> _workspaces;
        public ObservableCollection<FormViewModel> Workspaces 
        {
            get => _workspaces;
            set => SetField(ref _workspaces, value);
        }
        
        public ICommand OpenInstructionsCommand { get; }
        public ICommand OpenDialogFormCommand { get; }
        public ICommand OpenFormCommand { get; }
        public ICommand OpenFormErrorCommand { get; }

        public MainWindowViewModel()
        {
            Workspaces = new ObservableCollection<FormViewModel>();
            
            OpenInstructionsCommand = new DelegateCommand(OpenInstructions);
            OpenDialogFormCommand = new DelegateCommand(OpenFormDialog);
            OpenFormCommand = new DelegateCommand(() => OpenChildForm());
            OpenFormErrorCommand = new DelegateCommand(() => OpenChildForm(true));

            OpenInstructions();
        }
        
        private void OpenInstructions()
        {
            if (Workspaces.Any(w => w.ViewType == ViewType.Instructions))
            {
                var instructions = Workspaces.First(w => w.ViewType == ViewType.Instructions);
                SelectedWorkspace = instructions;
                return;
            }

            var type = typeof(frmInstructions);
            OpenFormWorkspace(type, ViewType.Instructions);
        }

        private void OpenChildForm(bool setParent = false)
        {
            var type = typeof(frmChildForm);
            OpenFormWorkspace(type, ViewType.ChildForm, setParent);
        }
        
        public void OpenFormWorkspace(Type formType, ViewType viewType, bool setInvalidOwner = false)
        {
            try
            {
                var closeCommand = new DelegateCommand(() => CloseWorkspace(viewType));
                var workspace = new FormViewModel(viewType, formType, closeCommand);

                if (setInvalidOwner)
                {
                    var title = "WARNING: UNSAVED WORK WILL BE LOST";
                    var warning = "WARNING: If you continue and select a button from this invalid Form your computer will freeze ";
                    warning += $"and you will lose ALL unsaved work.{Environment.NewLine}{Environment.NewLine}";
                    warning += "If you need to save other work before continuing select 'Cancel'.";
                    warning += "To continue and test the bug select 'OK'.";

                    var response = MessageBox.Show(MainWindow, warning, title, MessageBoxButton.OKCancel);
                    if (response != MessageBoxResult.OK) return;

                    var winForm = workspace.WinForm;

                    //  this should NOT be allowed to happen, the WinForms control is inside of a FormsIntegrationHost
                    //  which is inside of the WPF Window. The Window is the parent, but the Window's Owner can be set to
                    //  a child WinForms control's Handle which crashes Windows
                    var windowInteropHelper = new WindowInteropHelper(MainWindow);
                    windowInteropHelper.Owner = winForm.Handle;
                }

                Workspaces.Add(workspace);

                SelectedWorkspace = workspace;
            }
            catch (Exception ex)
            {
                var message = $"An error occurred in {nameof(OpenFormWorkspace)} for form {viewType.ToString()}. {ex.Message}";
                throw new ApplicationException(message, ex);
            }
        }

        public void OpenFormDialog()
        {
            using (var frm = new frmDialogTest())
            {
                frm.ShowDialog(MainWindow);
            }
        }
        
        private void CloseWorkspace(ViewType viewType)
        {
            var pendingRemoval = Workspaces.Where(w => w.ViewType == viewType);
            foreach (var item in pendingRemoval)
            {
                Workspaces.Remove(item);
            }
        }

    }
}
