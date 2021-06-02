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
        private ChartHelper chartHelper;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serial = new SerialConnection(this);
            chartHelper = new ChartHelper();
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
            // łączenie
            if (!serial.PortOpen)
            {
                if (serial.CreateConnection())
                {
                    connectButton.Text = "Rozłącz";
                    logs.StartLogging();
                    chooseDataGroup.Enabled = false;
                    logGroup.Enabled = false;
                }
            }
            else
            {
                serial.CloseConnection();
                connectButton.Text = "Połącz";
                logs.StopLogging();
                chooseDataGroup.Enabled = true;
                logGroup.Enabled = true;
            }
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            AirData.CheckedValues[e.Index] = (e.NewValue == CheckState.Checked);
            //List<UserControl> tempList = new List<UserControl> { GaugeSpeed, GaugeAltitude, GaugeVerticalSpeed, TemperatureTextGauge, TASTextGauge };
            //for(int i = 0; i<tempList.Count; i++)
            //{
            //    tempList[i].Enabled = AirData.CheckedValues[i];
            //}
        }

        public void changeStatusIndicator(bool status)
        {
            if (status)
                StatusPicture.Image = Properties.Resources.green;
            else
                StatusPicture.Image = Properties.Resources.red;
        }

        public void changeDataIndicator(bool status)
        {
            if (status)
                DataPicture.Image = Properties.Resources.green;
            else
                DataPicture.Image = Properties.Resources.red;
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
            if (TemperatureTextGauge.Enabled)
                TemperatureTextGauge.Enabled = false;
            else
                TemperatureTextGauge.Enabled = true;
        }

        private void chartDataChoiceCheckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            chartHelper.CheckedValues[e.Index] = (e.NewValue == CheckState.Checked);
            UpdateChartVisibility(chartHelper.CheckedValues);
        }

        public void UpdateChartVisibility(List<bool> Vis)
        {
            for(int i = 0; i < Vis.Count; i++)
            {
                mainChart.Series[i].Enabled = Vis[i];
            }
        }

    }
}
