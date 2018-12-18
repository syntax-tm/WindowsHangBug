using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WindowsCrashDemo.Common
{
    public abstract class Observable : INotifyPropertyChanged
    {
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            Debug.Assert(!string.IsNullOrEmpty(propertyName));

            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;

            OnPropertyChanged(propertyName);

            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
