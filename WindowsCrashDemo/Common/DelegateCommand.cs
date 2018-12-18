using System;
using System.Windows.Input;

namespace WindowsCrashDemo.Common
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Func<bool> _canExecute;
        private readonly Action _executeAction;
        private bool _canExecuteCache = true;
        
        public DelegateCommand(Action executeAction, Func<bool> canExecute = null)
        {
            _executeAction = executeAction;
            _canExecute = canExecute;
        }
        
        public void Execute(object parameter)
        {
            _executeAction();
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) return _canExecuteCache;

            var temp = _canExecute();
            if (_canExecuteCache == temp) return _canExecuteCache;

            _canExecuteCache = temp;
            CanExecuteChanged?.Invoke(this, new EventArgs());
            return _canExecuteCache;
        }
    }
}
