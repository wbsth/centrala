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
        private string _ComPort = "COM1";
        public string ComPort
        {
            get
            {
                return _ComPort;
            }
            set {
                if (Equals(value, _ComPort)) return;
                _ComPort = value;
                OnPropertyChanged();
            }
        }
        public int BaudRate { get; set; } = 9600;
        public int DataBits { get; set; } = 8;
        public Parity ParitySetting { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;

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
