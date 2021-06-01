
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
            this.unitValue = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gaugeTitle.Size = new System.Drawing.Size(200, 22);
            this.gaugeTitle.TabIndex = 1;
            this.gaugeTitle.Text = "NAZWA_PRZYRZĄDU";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::centrala.Properties.Resources.wskazowka_mala;
            this.pictureBox2.Location = new System.Drawing.Point(0, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::centrala.Properties.Resources.predkosciomierz;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.unitValue);
            this.Controls.Add(this.gaugeValue);
            this.Controls.Add(this.gaugeTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gauge";
            this.Size = new System.Drawing.Size(200, 228);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox gaugeTitle;
        private System.Windows.Forms.TextBox gaugeValue;
        private System.Windows.Forms.TextBox unitValue;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
