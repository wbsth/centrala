using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace centrala
{
    public class SerialConnection : INotifyPropertyChanged
    {
        // domyślne ustawienia
        private string _comPort = "COM1";
        public string comPort
        {
            get
            {
                return _comPort;
            }
            set {
                if (Equals(value, _comPort)) return;
                _comPort = value;
                OnPropertyChanged();
            }
        }
        public int baudRate { get; set; } = 9600;
        public int dataBits { get; set; } = 8;
        public Parity paritySetting { get; set; } = Parity.None;
        public StopBits stopBits { get; set; } = StopBits.One;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SerialConnection(MainForm mainForm)
        {

        }

    }
}
