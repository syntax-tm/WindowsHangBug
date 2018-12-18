using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Interop;
using IWin32Window = System.Windows.Forms.IWin32Window;

namespace WindowsCrashDemo
{
    public partial class MainWindow : IWin32Window, IDisposable
    {

        private bool _disposed;

        public IntPtr Handle { get; }

        public MainWindow()
        {
            InitializeComponent();

            var interopHelper = new WindowInteropHelper(this);
            Handle = interopHelper.EnsureHandle();
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr handle);

        private void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                CloseHandle(Handle);
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
