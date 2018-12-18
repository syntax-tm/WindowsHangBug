using System.ComponentModel;

namespace WindowsCrashDemo.Common
{

    public enum AppExitCode
    {
        [Description("OnAppDomainException")]
        AppDomainException = -99,
        [Description("OnWinFormsThreadException")]
        WinFormsThreadException = -80,
        [Description("OnDispatcherException")]
        DispatcherException = -70,
        [Description("OnUnobservedTaskException")]
        UnobservedTaskException = -20,
        [Description("AppStartupException")]
        AppStartupException = -11,
        [Description("UserExitOnException")]
        UserExitOnException = -10,
        [Description("OK")]
        OK = 0
    }

    public enum CanCloseResult
    {
        Yes,
        No,
        Cancel
    }

    public enum ViewType
    {
        MainWindow,
        ChildForm,
        DialogForm,
        Instructions
    }
}
