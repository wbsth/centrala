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
                _ValLabel = ValueLabel.Text = value;
                
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
                ValueResult.Text = value.ToString();
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

    }
}
