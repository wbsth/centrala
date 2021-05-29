using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace centrala
{
    public partial class SettingsForm : Form
    {
        public static List<int> baudRatesList = new List<int>
        {
            75,
            110,
            134,
            150,
            300,
            600,
            1200,
            1800,
            2400,
            4800,
            7200,
            9600,
            14400,
            19200,
            38400,
            57600,
            115200,
            128000
        };
        public static List<KeyValuePair<Parity, string>> parityTypesList = new List<KeyValuePair<Parity, string>>
        {
            new KeyValuePair<Parity, string>(Parity.Even, "Parzyste"),
            new KeyValuePair<Parity, string>(Parity.Mark, "Znacznik"),
            new KeyValuePair<Parity, string>(Parity.None, "Brak"),
            new KeyValuePair<Parity, string>(Parity.Odd, "Nieparzyste"),
            new KeyValuePair<Parity, string>(Parity.Space, "Spacja"),
        };
        public static List<KeyValuePair<StopBits, string>> stopBitsList = new List<KeyValuePair<StopBits, string>>
        {
            new KeyValuePair<StopBits, string>(StopBits.None, "0"),
            new KeyValuePair<StopBits, string>(StopBits.One, "1"),
            new KeyValuePair<StopBits, string>(StopBits.OnePointFive, "1.5"),
            new KeyValuePair<StopBits, string>(StopBits.Two, "2")
        };
        public static List<int> dataBitsList = new List<int>
        {
            4,
            5,
            6,
            7,
            8
        };

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            PortComboBox.DataSource = SerialPort.GetPortNames();

            BaudRateComboBox.DataSource = baudRatesList;
            BaudRateComboBox.SelectedIndex = baudRatesList.IndexOf(9600);

            ParityComboBox.DataSource = parityTypesList;
            ParityComboBox.ValueMember = "Key";
            ParityComboBox.DisplayMember = "Value";
            ParityComboBox.SelectedIndex = 2;

            StopBitsComboBox.DataSource = stopBitsList;

            DataBitsComboBox.DataSource = dataBitsList;
            DataBitsComboBox.SelectedIndex = dataBitsList.IndexOf(8);
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            ((MainForm)Owner).serial.comPort = (string)PortComboBox.SelectedValue;
            ((MainForm)Owner).serial.baudRate = (int)BaudRateComboBox.SelectedValue;
            ((MainForm)Owner).serial.paritySetting = (Parity)ParityComboBox.SelectedValue;
            ((MainForm)Owner).serial.dataBits = (int)DataBitsComboBox.SelectedValue;
            ((MainForm)Owner).serial.stopBits = (StopBits)StopBitsComboBox.SelectedValue;
            MessageBox.Show("Zapisano");
        }

    }
}
