
namespace centrala
{
    partial class Gauge
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gaugeTitle = new System.Windows.Forms.TextBox();
            this.gaugeValue = new System.Windows.Forms.TextBox();
            this.handSmall = new System.Windows.Forms.PictureBox();
            this.mainGauge = new System.Windows.Forms.PictureBox();
            this.handBig = new System.Windows.Forms.PictureBox();
            this.unitValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.handSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handBig)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeTitle
            // 
            this.gaugeTitle.BackColor = System.Drawing.SystemColors.Control;
            this.gaugeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gaugeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaugeTitle.Location = new System.Drawing.Point(0, 0);
            this.gaugeTitle.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeTitle.Name = "gaugeTitle";
            this.gaugeTitle.ReadOnly = true;
            this.gaugeTitle.Size = new System.Drawing.Size(200, 22);
            this.gaugeTitle.TabIndex = 1;
            this.gaugeTitle.Text = "TEST";
            this.gaugeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gaugeValue
            // 
            this.gaugeValue.BackColor = System.Drawing.SystemColors.Control;
            this.gaugeValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gaugeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaugeValue.Location = new System.Drawing.Point(0, 203);
            this.gaugeValue.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.gaugeValue.Name = "gaugeValue";
            this.gaugeValue.Size = new System.Drawing.Size(98, 22);
            this.gaugeValue.TabIndex = 1;
            this.gaugeValue.Text = "0";
            this.gaugeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // handSmall
            // 
            this.handSmall.BackColor = System.Drawing.Color.Transparent;
            this.handSmall.Image = global::centrala.Properties.Resources.wskazowka_mala;
            this.handSmall.Location = new System.Drawing.Point(0, 30);
            this.handSmall.Name = "handSmall";
            this.handSmall.Size = new System.Drawing.Size(200, 173);
            this.handSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handSmall.TabIndex = 2;
            this.handSmall.TabStop = false;
            // 
            // mainGauge
            // 
            this.mainGauge.Image = global::centrala.Properties.Resources.plane;
            this.mainGauge.Location = new System.Drawing.Point(0, 30);
            this.mainGauge.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mainGauge.Name = "mainGauge";
            this.mainGauge.Size = new System.Drawing.Size(200, 173);
            this.mainGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainGauge.TabIndex = 0;
            this.mainGauge.TabStop = false;
            // 
            // handBig
            // 
            this.handBig.Image = global::centrala.Properties.Resources.wskazowka_duza;
            this.handBig.Location = new System.Drawing.Point(0, 30);
            this.handBig.Name = "handBig";
            this.handBig.Size = new System.Drawing.Size(200, 173);
            this.handBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.handBig.TabIndex = 3;
            this.handBig.TabStop = false;
            this.handBig.Visible = false;
            // 
            // unitValue
            // 
            this.unitValue.BackColor = System.Drawing.SystemColors.Control;
            this.unitValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitValue.Location = new System.Drawing.Point(104, 203);
            this.unitValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.unitValue.Name = "unitValue";
            this.unitValue.Size = new System.Drawing.Size(98, 22);
            this.unitValue.TabIndex = 1;
            this.unitValue.Text = "km/h";
            // 
            // Gauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.handBig);
            this.Controls.Add(this.handSmall);
            this.Controls.Add(this.unitValue);
            this.Controls.Add(this.gaugeValue);
            this.Controls.Add(this.gaugeTitle);
            this.Controls.Add(this.mainGauge);
            this.Name = "Gauge";
            this.Size = new System.Drawing.Size(200, 228);
            ((System.ComponentModel.ISupportInitialize)(this.handSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainGauge;
        private System.Windows.Forms.TextBox gaugeTitle;
        private System.Windows.Forms.TextBox gaugeValue;
        private System.Windows.Forms.PictureBox handSmall;
        private System.Windows.Forms.PictureBox handBig;
        private System.Windows.Forms.TextBox unitValue;
    }
}
