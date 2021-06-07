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
    public partial class Gauge : UserControl
    {
        const double speedConst = 0.818181;
        const double altitudeConstBig = 27.77777;
        const double altitudeConstSmall = 2.777777;
        const double speedVerticalConst = 18;

        private delegate void SafeCallDelegate();

        public enum IndicatorTypes
        {
            speed,
            speedVertical,
            altitude
        }
        private IndicatorTypes _Type;

        [Description("Type of the gauge")]
        public IndicatorTypes DesignerType
        {
            get 
            {
                return _Type;
            }
            set
            {
                _Type = value;
                SetImages();
            }
        }

        private double _GaugeValue;
        public double GaugeValue
        {
            get
            {
                return _GaugeValue;
            }
            set
            {
                if (Equals(value, _GaugeValue)) return;
                _GaugeValue = value;
                UpdateValue();
            }
        }

        private string unit;

        public Gauge()
        {
            InitializeComponent();        
        }

        private void SetImages()
        {

            handSmall.Parent = mainGauge;
            handSmall.BackColor = Color.Transparent;
            handSmall.Location = new Point(0, 0);

            handBig.Parent = handSmall;
            handBig.BackColor = Color.Transparent;
            handBig.Location = new Point(0, 0);

            if (_Type == IndicatorTypes.altitude)
            {
                gaugeTitle.Text = "Wysokość";
                unit = "m";
                mainGauge.Image = Properties.Resources.wysokosc;
                handBig.Visible = true;
            }
            else if (_Type == IndicatorTypes.speed)
            {
                gaugeTitle.Text = "IAS";
                unit = "km/h";
                mainGauge.Image = Properties.Resources.predkosciomierz;
            }
            else if (_Type == IndicatorTypes.speedVertical)
            {
                gaugeTitle.Text = "W";
                unit = "m/s";
                mainGauge.Image = Properties.Resources.wznoszenie;
            }
            UpdateValue();
        }

        public void UpdateValue()
        {
            if (gaugeValueLabel.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateValue);
                gaugeValueLabel.Invoke(d, new object[] { });
            }
            else
            {
                if (!this.Enabled) return;
                gaugeValueLabel.Text = $"{_GaugeValue} {unit}";
                // update rotation
                Rotate(_GaugeValue);
            }
        }

        public void Rotate(double value)
        {
            float tempRotation;
            float tempRotationBig;
            if (_Type == IndicatorTypes.speed)
            {
                if (value > 40 && value < 480)
                {
                    tempRotation = (float)((value - 40) * speedConst);                  
                }
                else 
                {
                    tempRotation = 0;                
                }
                handSmall.Image = Helpers.RotateImage(Properties.Resources.wskazowka_mala_obrocona, tempRotation);
            }
            else if (_Type == IndicatorTypes.speedVertical)
            {
                tempRotation = (float)(value * speedVerticalConst);
                handSmall.Image = Helpers.RotateImage(Properties.Resources.wskazowka_mala_obrocona, -90+tempRotation);
            }
            else if (_Type == IndicatorTypes.altitude)
            {
                tempRotation = (float)(value / altitudeConstSmall);
                tempRotationBig = (float)(value / altitudeConstBig);
                handSmall.Image = Helpers.RotateImage(Properties.Resources.wskazowka_mala_obrocona, 180 + tempRotation);
                handBig.Image = Helpers.RotateImage(Properties.Resources.wskazowka_duza_obrocona, 180 + tempRotationBig);
            }
        }

        private void Gauge_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.Enabled)
            {
                // wylaczenie zegara
                mainGauge.Image = Helpers.SetImageOpacity(mainGauge.Image, (float)0.4);
                handSmall.Image = Helpers.SetImageOpacity(handSmall.Image, (float)0.4);
                handBig.Image = Helpers.SetImageOpacity(handBig.Image, (float)0.4);
            }
            else
            {
                // wlaczenie zegara
                SetImages();
            }
        }
    }
}
