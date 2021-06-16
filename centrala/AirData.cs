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
        MainForm form;

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
                if (!Equals(value, _Altitude))
                    _Altitude = value;
                AltitudeArchive.EnterValue(value);
                form.UpdateChartBindingsSafe(1);
                OnPropertyChanged();
            }
        }
        public double SpeedIAS
        {
            get { return _SpeedIAS; }
            set
            {
                if (!Equals(value, _SpeedIAS))
                    _SpeedIAS = value;
                SpeedIASArchive.EnterValue(value);
                form.UpdateChartBindingsSafe(0);
                OnPropertyChanged();
            }
        }
        public double SpeedTAS
        {
            get { return _SpeedTAS; }
            set
            {
                if (!Equals(value, _SpeedTAS))
                    _SpeedTAS = value;
                SpeedTASArchive.EnterValue(value);
                form.UpdateChartBindingsSafe(4);
                OnPropertyChanged();
            }
        }
        public double SpeedVertical
        {
            get { return _SpeedVertical; }
            set
            {
                if (!Equals(value, _SpeedVertical))
                    _SpeedVertical = value;
                SpeedVerticalArchive.EnterValue(value);
                form.UpdateChartBindingsSafe(2);
                OnPropertyChanged();
            }
        }
        public double Temperature
        {
            get { return _Temperature; }
            set
            {
                if (!Equals(value, _Temperature))
                    _Temperature = value;
                TemperatureArchive.EnterValue(value);
                form.UpdateChartBindingsSafe(3);
                OnPropertyChanged();
            }
        }

        private List<double> _CurrentValues = new List<double>(new double[5]);
        public List<double> CurrentValues
        {
            get
            {
                _CurrentValues[0] = SpeedIAS;
                _CurrentValues[1] = Altitude;
                _CurrentValues[2] = SpeedVertical;
                _CurrentValues[3] = Temperature;
                _CurrentValues[4] = SpeedTAS;
                return _CurrentValues;
            }
            set
            {
                _CurrentValues = value;
            }
        }

        private ArchiveBuffer AltitudeArchive = new ArchiveBuffer();
        private ArchiveBuffer SpeedIASArchive = new ArchiveBuffer();
        private ArchiveBuffer SpeedTASArchive = new ArchiveBuffer();
        private ArchiveBuffer SpeedVerticalArchive = new ArchiveBuffer();
        private ArchiveBuffer TemperatureArchive = new ArchiveBuffer();
        public ArchiveBuffer TimeBuffer = new ArchiveBuffer(true);

        public List<ArchiveBuffer> ArchivesList;

        public static List<KeyValuePair<double, string>> ValuesList; 
        public static List<bool> CheckedValues { get; set; } = new List<bool>(new bool[5]);

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public AirData(MainForm form)
        {
            this.form = form;
            ValuesList = new List<KeyValuePair<double, string>>
            {
                new KeyValuePair<double, string>(SpeedIAS, "IAS"),
                new KeyValuePair<double, string>(Altitude, "Wysokosc"),
                new KeyValuePair<double, string>(SpeedVertical, "W"),
                new KeyValuePair<double, string>(Temperature, "Temperatura"),
                new KeyValuePair<double, string>(SpeedTAS, "TAS"),
            };
            ArchivesList = new List<ArchiveBuffer>
            {
                SpeedIASArchive,
                AltitudeArchive,
                SpeedVerticalArchive,
                TemperatureArchive,
                SpeedTASArchive,
                TimeBuffer
            };   
        }

        public void ClearArchiveData()
        {
            foreach(ArchiveBuffer item in ArchivesList)
            {
                item.ClearBuffer();
            }
        }
    }
}
