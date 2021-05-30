using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace centrala
{
    public class SerialConnection
    {
        // domyślne ustawienia
        public string comPort { get; set; } = "COM1";
        public int baudRate { get; set; } = 9600;
        public int dataBits { get; set; } = 8;
        public Parity paritySetting { get; set; } = Parity.None;
        public StopBits stopBits { get; set; } = StopBits.One;

        public SerialConnection(MainForm mainForm)
        {

        }

    }
}
