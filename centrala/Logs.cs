using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace centrala
{
    public class Logs : INotifyPropertyChanged
    {
        private double _SavingInterval = 1;
        private bool _SavingEnabled = true;
        public double SavingInterval
        {
            get
            { return _SavingInterval; }
            set
            {
                if (Equals(value, _SavingInterval)) return;
                _SavingInterval = value;
                OnPropertyChanged();
            }
        }

        public bool SavingEnabled
        {
            get
            { return _SavingEnabled; }
            set
            {
                if (Equals(value, _SavingEnabled)) return;
                _SavingEnabled = value;
                OnPropertyChanged();                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}