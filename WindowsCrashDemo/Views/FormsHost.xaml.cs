using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsCrashDemo.Views
{
    public partial class FormsHost : IDisposable
    {
        private bool _disposed;
        
        private ICommand CloseTabCommand { get; set; }

        public Form WinForm { get; set; }

        public FormsHost()
        {
            InitializeComponent();
        }

        public FormsHost(Type formType, ICommand closeTabCommand) : this()
        {
            InitializeComponent();
            
            CloseTabCommand = closeTabCommand;

            var winForm = (Form) Activator.CreateInstance(formType);
            
            //  suspend drawing and layout operations
            winForm.SuspendLayout();

            WinForm = winForm;
            
            winForm.TopLevel = false;
            winForm.FormBorderStyle = FormBorderStyle.None;
            
            frmHost.Child = winForm;

            winForm.FormClosed += OnFormClosed;
            
            //  resume drawing and layout operations
            winForm.ResumeLayout();
        }
        
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            CloseTabCommand.Execute(null);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                if (WinForm != null)
                {
                    WinForm.FormClosed -= OnFormClosed;
                    WinForm.Dispose();
                    WinForm = null;
                }
                frmHost?.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
