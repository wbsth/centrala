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
        private int rotation = 0;

        public Gauge()
        {
            InitializeComponent();        
        }

        private void SetImages()
        {

            //mainGauge.Controls.Add(handSmall);
            handSmall.Parent = mainGauge;
            handSmall.BackColor = Color.Transparent;
            handSmall.Location = new Point(0, 0);

            //mainGauge.Controls.Add(handBig);
            handBig.Parent = handSmall;
            handBig.BackColor = Color.Transparent;
            handBig.Location = new Point(0, 0);

            if (_Type == IndicatorTypes.altitude)
            {
                gaugeTitle.Text = "Wysokość";
                unitValue.Text = "m";
                mainGauge.Image = Properties.Resources.wysokosc;
                handBig.Visible = true;
            }
            else if (_Type == IndicatorTypes.speed)
            {
                gaugeTitle.Text = "IAS";
                unitValue.Text = "km/h";
                mainGauge.Image = Properties.Resources.predkosciomierz;
            }
            else if (_Type == IndicatorTypes.speedVertical)
            {
                gaugeTitle.Text = "W";
                unitValue.Text = "m/s";
                mainGauge.Image = Properties.Resources.wznoszenie;
            }
        }

        public void Rotate(int rotation)
        {
            handSmall.Image = Helpers.RotateImage(handSmall.Image, rotation);
            this.rotation += rotation;
        }
    }
}
