using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsCrashDemo.Common;
using WindowsCrashDemo.Views;

namespace WindowsCrashDemo.ViewModels
{
    public class FormViewModel : Observable
    {

        private static readonly Thread _currentThread = Thread.CurrentThread;
        private static readonly string _currentThreadName = $"{_currentThread.Name} ({_currentThread.ManagedThreadId})";
        
        private readonly Type _formType;
        
        public Form WinForm { get; set; }
        public FormsHost FormContext { get; set; }
        public string DisplayName { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public ViewType ViewType { get; }
        public string Identifier { get; }

        public ICommand CloseCommand { get; }
        
        public FormViewModel()
        {

        }
        
        public FormViewModel(ViewType viewType, Type formType, ICommand closeTabCommand)
                : this()
        {
            ViewType = viewType;
            Title = viewType.GetDescription();
            Identifier = DisplayName = Title;
            
            CloseCommand = closeTabCommand;

            _formType = formType;

            CreateForm();
        }

        private void CreateForm()
        {
            Debug.WriteLine($"{_formType.Name} WinForm creation started on thread '{_currentThreadName}'");

            FormContext = new FormsHost(_formType, CloseCommand);
            WinForm = FormContext.WinForm;
            
            if (!string.IsNullOrEmpty(WinForm.Text))
            {
                DisplayName = WinForm.Text;
            }
            
            WinForm.TextChanged += OnFormTextChanged;
            
            Debug.WriteLine($"{_formType.Name} WinForm created on thread '{_currentThreadName}'");
        }

        private void OnFormTextChanged(object sender, EventArgs e)
        {
            var oldText = DisplayName;
            var newText = WinForm.Text;

            DisplayName = newText;

            Debug.WriteLine($"{WinForm.Name} ({oldText}) 'Text' has been updated to {newText}");
        }
        
        public CanCloseResult CanClose()
        {
            if (WinForm != null)
            {
                WinForm.TextChanged -= OnFormTextChanged;
                WinForm.Close();

                return WinForm == null || WinForm.IsDisposed ? CanCloseResult.Yes : CanCloseResult.No;
            }
            return CanCloseResult.Yes;
        }
    }
}