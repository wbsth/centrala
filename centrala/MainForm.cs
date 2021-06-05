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
        private delegate void SafeCallDelegate(int val);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            airData = new AirData(this);
            serial = new SerialConnection(this, airData);
            logs = new Logs();

            portValue.DataBindings.Add(new Binding("Text", serial, "ComPort"));
            intervalValue.DataBindings.Add(new Binding("Value", logs, "SavingInterval"));
            intervalCheckbox.DataBindings.Add(new Binding("Checked", logs, "SavingEnabled"));

            TemperatureTextGauge.DataBindings.Add(new Binding("ValValue", airData, "Temperature"));
            TASTextGauge.DataBindings.Add(new Binding("ValValue", airData, "SpeedTAS"));
            GaugeSpeed.DataBindings.Add(new Binding("GaugeValue", airData, "SpeedIAS"));
            GaugeAltitude.DataBindings.Add(new Binding("GaugeValue", airData, "Altitude"));
            GaugeVerticalSpeed.DataBindings.Add(new Binding("GaugeValue", airData, "SpeedVertical"));

            //mainChart.DataSource = airData.ArchivesList;
            //mainChart.Series[0].YValueMembers = "[0].Buffer";//Points.DataBindY(airData.ArchivesList[0].Buffer);
            mainChart.Series[0].Points.DataBindY(airData.ArchivesList[0].Buffer);

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
                    chartDataChoiceCheckbox.Enabled = false;
                }
            }
            else
            {
                serial.CloseConnection();
                connectButton.Text = "Połącz";
                logs.StopLogging();
                chooseDataGroup.Enabled = true;
                logGroup.Enabled = true;
                chartDataChoiceCheckbox.Enabled = true;
            }
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            AirData.CheckedValues[e.Index] = (e.NewValue == CheckState.Checked);
            List<UserControl> tempGaugeList = new List<UserControl> { GaugeSpeed, GaugeAltitude, GaugeVerticalSpeed, TemperatureTextGauge, TASTextGauge };
            for (int i = 0; i < tempGaugeList.Count; i++)
            {
                tempGaugeList[i].Enabled = AirData.CheckedValues[i];
            }
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
            mainChart.Series[0].Points.DataBindY(airData.ArchivesList[0].Buffer);
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
            ChartHelper.CheckedValues[e.Index] = (e.NewValue == CheckState.Checked);
            UpdateChartVisibility(ChartHelper.CheckedValues);
        }

        public void UpdateChartVisibility(List<bool> Vis)
        {
            for(int i = 0; i < Vis.Count; i++)
            {
                mainChart.Series[i].Enabled = Vis[i];
            }
        }

        public void UpdateChartBindingsSafe(int number)
        {
            if (mainChart.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChartBindingsSafe);
                mainChart.Invoke(d, new object[] { number });
            }
            else
            {
                mainChart.Series[number].Points.DataBindY(airData.ArchivesList[number].Buffer);
            }           
        }

    }
}
