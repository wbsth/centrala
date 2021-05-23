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
        public string comPort { get; set; } = "COM1";
        public int baudRate { get; set; } = 9600;
        public int dataBits { get; set; } = 8;
        public Parity paritySetting { get; set; } = Parity.None;
        public double stopBits { get; set; } = 1;

        public SerialConnection()
        {

        }

    }
}
