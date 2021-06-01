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
        SerialPort port;
        List<byte> tempBytes = new List<byte>();
        private readonly MainForm form;

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
            this.form = mainForm;
        }

        public void CreateConnection()
        {
            if(port != null)
            {
                CloseConnection();
            }
            port = new SerialPort(_ComPort, BaudRate, ParitySetting, DataBits, StopBits);
            port.DataReceived += Port_DataReceived;
            port.Open();
            form.changeStatusIndicator(true);
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while(port.BytesToRead > 0)
            {
                tempBytes.Add((byte)port.ReadByte());
            }
        }

        public void CloseConnection()
        {
            port.Close();
            port.Dispose();
            form.changeStatusIndicator(false);
        }
    }
}
