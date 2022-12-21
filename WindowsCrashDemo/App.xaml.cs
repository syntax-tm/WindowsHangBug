using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using WindowsCrashDemo.Common;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;

namespace WindowsCrashDemo
{
    public partial class App : Application
    {

        public static string ApplicationName { get; protected set; } 
        public static string ApplicationVersion { get; protected set; }
        public static bool MainWindowLoaded { get; internal set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                //  handle any WinForms thread exceptions
                System.Windows.Forms.Application.ThreadException += OnWinFormsThreadException;
                System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                //  handle any WPF dispatcher exceptions
                Current.DispatcherUnhandledException += OnDispatcherException;

                //  handle any AppDomain exceptions
                var current = AppDomain.CurrentDomain;
                current.UnhandledException += OnAppDomainException;
                
                //  handle any TaskScheduler exceptions
                TaskScheduler.UnobservedTaskException += OnUnobservedTaskException;

                ApplicationName = nameof(WindowsCrashDemo);
                ApplicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

                Thread.CurrentThread.Name = @"WPF_UI_THREAD";

                var mainWindow = new MainWindow();
                MainWindow = mainWindow;
                
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                var message = $"An unhandled {ex.GetType().Name} occurred during the application's {nameof(OnStartup)} event. {ex.Message}";
                var aex = new ApplicationException(message, ex);

                Debug.WriteLine(message, aex);

                ApplicationExit(AppExitCode.AppStartupException);
            }
        }
        
        private void OnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            try
            {
                var exception = e.Exception;
                if (exception == null) throw new ArgumentNullException(nameof(exception));

                LogAndShowException(exception, AppExitCode.UnobservedTaskException, true);

                e.SetObserved();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred handling the {nameof(OnUnobservedTaskException)} event. {ex.Message}", ex);
                ApplicationExit(AppExitCode.UnobservedTaskException);
            }
        }
        
        private void OnWinFormsThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                var exception = e.Exception;

                LogAndShowException(exception, AppExitCode.WinFormsThreadException);
            }
            catch (Exception ex)
            {
                var message = $"A fatal {ex.GetType().Name} occurred while handling the {nameof(OnWinFormsThreadException)} event. {ex.Message}";
                Debug.WriteLine(message, ex);
            }
            finally
            {
                ApplicationExit(AppExitCode.WinFormsThreadException);
            }
        }

        private void OnAppDomainException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var exception = (Exception) e.ExceptionObject;
                LogAndShowException(exception, AppExitCode.AppDomainException);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"A fatal {ex.GetType().Name} occurred while handling the {nameof(OnAppDomainException)}. {ex.Message}", ex);
            }
            finally
            {
                ApplicationExit(AppExitCode.AppDomainException);
            }
        }

        private void OnDispatcherException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                var exception = e.Exception;

                LogAndShowException(exception, AppExitCode.DispatcherException, true);
                
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred handling the {nameof(OnDispatcherException)} event. {ex.Message}", ex);
                ApplicationExit(AppExitCode.DispatcherException);
            }
        }

        private void LogAndShowException(Exception exception, AppExitCode exitCode, bool canContinue = false)
        {
            if (exception == null) throw new ArgumentNullException(nameof(exception));
            if (!canContinue)
            {
                CheckMainWindowShown(exception);
            }

            try
            {
                MessageBoxButton button;
                var messageSb = new StringBuilder();
                messageSb.AppendLine($"WARNING: An unhandled {exception.GetType().Name} occurred. {exception.Message}");
                messageSb.AppendLine(Environment.NewLine);

                if (canContinue)
                {
                    messageSb.Append("It is highly recommended that you close out of the application and restart before continuing.");
                    messageSb.Append(" Would you like to exit the application now? (Select 'Yes' to close, 'No' to continue)");

                    button = MessageBoxButton.YesNo;
                }
                else
                {
                    messageSb.Append("The application cannot continue and will exit. Press 'Ok' to exit the application.");

                    button = MessageBoxButton.OK;
                }

                Current.Dispatcher.Invoke(DispatcherPriority.Send, new Action(() =>
                {
                    var title = $"{ApplicationName} {ApplicationVersion} Unhandled Application Exception";
                    var message = messageSb.ToString();

                    var result = MessageBox.Show(message, title, button, MessageBoxImage.Error);

                    if (!canContinue)
                    {
                        Debug.WriteLine($"A fatal {exitCode.GetDescription()} has occurred and the Application cannot continue. {exception.Message}", exception);

                        ApplicationExit(exitCode);

                        return;
                    }

                    var shouldClose = result == MessageBoxResult.Yes;
                    if (shouldClose)
                    {
                        Debug.WriteLine($"User has chosen to exit the application after handling the {exitCode.GetDescription()} event. {exception.Message}", exception);
                        
                        ApplicationExit(AppExitCode.UserExitOnException);
                        return;
                    }

                    Debug.WriteLine($"User has chosen to continue running the application after handling the {exitCode.GetDescription()} event. {exception.Message}", exception);
                    
                }));
            }
            catch (Exception e)
            {
                var handleErrorMessage = $"An unhandled {e.GetType().Name} occurred while handling the {exitCode.GetDescription()}. {e.Message}";
                throw new ApplicationException(handleErrorMessage, e);
            }
        }

        private void CheckMainWindowShown(Exception exception)
        {
            if (MainWindowLoaded) return;

            //  if the MainWindow isn't set, the app is probably starting so just log it and
            //  close the app since the code below needs the window's handle for the error dialog
            if (MainWindow == null)
            {
                var fatalSb = new StringBuilder();
                fatalSb.Append($"A fatal {exception.GetType().Name} occurred before the application's ");
                fatalSb.Append($"MainWindow was shown. {exception.Message}");

                Debug.WriteLine(fatalSb.ToString(), exception);

                ApplicationExit(AppExitCode.AppStartupException);
            }
        }

        internal static void ApplicationExit(AppExitCode oeExitCode = AppExitCode.OK)
        {
            var exitCode = (int) oeExitCode;
            
            Environment.ExitCode = exitCode;
            Environment.Exit(exitCode);
        }

    }
}
