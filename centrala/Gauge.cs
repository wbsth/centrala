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
        private int rotation = 0;

        public Gauge()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(0, 0);
        }

        public void Rotate(int rotation)
        {
            pictureBox2.Image = Helpers.RotateImage(pictureBox2.Image, this.rotation + rotation);
            this.rotation += rotation;
        }
    }
}
