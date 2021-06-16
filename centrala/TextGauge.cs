using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace centrala
{
    public partial class TextGauge : UserControl
    {
        private delegate void SafeCallDelegate(Label label, string val);

        public enum TextGaugesTypes
        {
            temperature,
            TAS
        }

        private TextGaugesTypes _GaugeType;
        [Description("Type of the gauge")]
        public TextGaugesTypes GaugeType
        {
            get
            {
                return _GaugeType;
            }
            set
            {
                _GaugeType = value;
                SetValues();
            }
        }

        private string _ValLabel;
        private double _ValValue;
        private string _ValUnit;
        public string ValLabel
        {
            get
            {
                return _ValLabel;
            }
            set
            {
                if (Equals(value, _ValLabel)) return;
                _ValLabel = value;
                UpdateSafe(ValueLabel, value);
            }
        }

        public double ValValue
        {
            get
            {
                return _ValValue;
            }
            set
            {
                if (Equals(value, _ValValue)) return;
                _ValValue = value;
                string tempString;
                if (_GaugeType == TextGaugesTypes.TAS)
                {
                    tempString = $"{value:0.}";
                }
                else
                {
                    tempString = $"{value:0.#}";
                }
                UpdateSafe(ValueResult, tempString);
            }
        }

        public string ValUnit
        {
            get
            {
                return _ValUnit;
            }
            set
            {
                if (Equals(value, _ValUnit)) return;
                _ValUnit = ValueUnit.Text = value;
            }
        }

        public TextGauge()
        {
            InitializeComponent();
        }

        public void SetValues()
        {
            if(GaugeType == TextGaugesTypes.TAS)
            {
                ValLabel = "TAS: ";
                ValUnit = "m/s";
            }
            else if(GaugeType == TextGaugesTypes.temperature)
            {
                ValLabel = "Temperatura: ";
                ValUnit = "°C";
            }
        }

        private void UpdateSafe(Label label, string val)
        {
            if (label.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateSafe);
                label.Invoke(d, new object[] { label, val });
            }
            else
                label.Text = val;             
        }

    }
}
