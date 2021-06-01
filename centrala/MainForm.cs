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
    public partial class MainForm : Form
    {
        protected internal SerialConnection serial;
        private AirData airData;
        private Logs logs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serial = new SerialConnection(this);
            airData = new AirData();
            logs = new Logs();

            portValue.DataBindings.Add(new Binding("Text", serial, "ComPort"));
            intervalValue.DataBindings.Add(new Binding("Value", logs, "SavingInterval"));
            intervalCheckbox.DataBindings.Add(new Binding("Checked", logs, "SavingEnabled"));

            TemperatureTextGauge.DataBindings.Add(new Binding("ValValue", airData, "Temperature"));
            TASTextGauge.DataBindings.Add(new Binding("ValValue", airData, "SpeedTAS"));
            GaugeSpeed.DataBindings.Add(new Binding("GaugeValue", airData, "SpeedIAS"));
            GaugeAltitude.DataBindings.Add(new Binding("GaugeValue", airData, "Altitude"));
            GaugeVerticalSpeed.DataBindings.Add(new Binding("GaugeValue", airData, "SpeedVertical"));

            //DataCheckbox.DataBindings.Add(new Binding("Items[0]", ));

            for (int i = 0; i < DataCheckbox.Items.Count; i++)
            {
                DataCheckbox.SetItemChecked(i, true);
            }
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm())
            {
                settingsForm.ShowDialog(this);
            }
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog(this);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //changeStatusIndicator(true);
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            airData.CheckedValues[e.Index] = (e.NewValue == CheckState.Checked);
            List<object> tempList = new List<object> { GaugeSpeed, GaugeAltitude, GaugeVerticalSpeed,  };
        }

        public void changeStatusIndicator(bool status)
        {
            if (status)
                statusPicture.Image = Properties.Resources.green;
            else
                statusPicture.Image = Properties.Resources.red;
        }

        public void changeDataIndicator(bool status)
        {
            if (status)
                dataPicture.Image = Properties.Resources.green;
            else
                dataPicture.Image = Properties.Resources.red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GaugeSpeed.GaugeValue += 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GaugeVerticalSpeed.GaugeValue += 0.25;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GaugeAltitude.GaugeValue += 750;
            if (TemperatureTextGauge.Enabled)
                TemperatureTextGauge.Enabled = false;
            else
                TemperatureTextGauge.Enabled = true;
        }
    }
}
