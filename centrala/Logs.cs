using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;

namespace centrala
{
    public class Logs : INotifyPropertyChanged
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        private AirData airData;
        private StreamWriter streamWriter;
        private List<int> CheckedIndices = new List<int>();
        private double _SavingInterval = 1;
        private bool _SavingEnabled = true;
        public double SavingInterval
        {
            get
            { return _SavingInterval; }
            set
            {
                if (Equals(value, _SavingInterval)) return;
                _SavingInterval = value;
                OnPropertyChanged();
            }
        }

        public bool SavingEnabled
        {
            get
            { return _SavingEnabled; }
            set
            {
                if (Equals(value, _SavingEnabled)) return;
                _SavingEnabled = value;
                OnPropertyChanged();                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public Logs(AirData airData)
        {
            this.airData = airData;
        }

        public void StartLogging()
        {
            if (SavingEnabled)
            {
                myTimer.Interval = (int)(SavingInterval * 1000);

                string timestamp = Helpers.GetTimestamp(DateTime.Now);
                streamWriter = new StreamWriter($"{timestamp}.csv", false);
                PrepareHeader();

                myTimer.Tick += MyTimer_Tick;
                myTimer.Start();
            }
        }

        public void StopLogging()
        {
            if (SavingEnabled)
            {
                myTimer.Stop();
                streamWriter.Close();
                CheckedIndices.Clear();
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            List<string> tempValues = new List<string>();

            foreach(var index in CheckedIndices)
            {
                tempValues.Add(airData.CurrentValues[index].ToString());
            }
            var joinedString = string.Join(";", tempValues);
            var time = Helpers.GetTimeStampPrecise(DateTime.Now);
            streamWriter.WriteLine($"{time};{joinedString}");
        }

        private void PrepareHeader()
        {
            List<string> tempStrings = new List<string>();
            for (int i = 0; i < AirData.CheckedValues.Count; i++)
            {
                if (AirData.CheckedValues[i])
                {
                    tempStrings.Add(AirData.ValuesList[i].Value);
                    CheckedIndices.Add(i);
                }
            }
            var joinedString = string.Join(";", tempStrings);
            streamWriter.WriteLine($"time;{joinedString}");
        }

    }
}