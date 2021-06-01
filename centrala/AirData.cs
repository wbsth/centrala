using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace centrala
{
    public class AirData : INotifyPropertyChanged
    {
        private double _Altitude = 0;
        private double _SpeedIAS = 0;
        private double _SpeedTAS = 0;
        private double _SpeedVertical = 0;
        private double _Temperature = 20;

        public double Altitude
        {
            get { return _Altitude; }
            set
            {
                if (Equals(value, _Altitude)) return;
                _Altitude = value;
                OnPropertyChanged();
            }
        }
        public double SpeedIAS
        {
            get { return _SpeedIAS; }
            set
            {
                if (Equals(value, _SpeedIAS)) return;
                _SpeedIAS = value;
                OnPropertyChanged();
            }
        }
        public double SpeedTAS
        {
            get { return _SpeedTAS; }
            set
            {
                if (Equals(value, _SpeedTAS)) return;
                _SpeedTAS = value;
                OnPropertyChanged();
            }
        }
        public double SpeedVertical
        {
            get { return _SpeedVertical; }
            set
            {
                if (Equals(value, _SpeedVertical)) return;
                _SpeedVertical = value;
                OnPropertyChanged();
            }
        }
        public double Temperature
        {
            get { return _Temperature; }
            set
            {
                if (Equals(value, _Temperature)) return;
                _Temperature = value;
                OnPropertyChanged();
            }
        }

        public List<bool> CheckedValues { get; set; } = new List<bool>(new bool[5]);

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public AirData()
        {
            //foreach(bool item in CheckedValues)
        }
    }
}
