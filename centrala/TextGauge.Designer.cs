
namespace centrala
{
    partial class TextGauge
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
            this.ValueUnit = new System.Windows.Forms.Label();
            this.ValueResult = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueUnit
            // 
            this.ValueUnit.AutoSize = true;
            this.ValueUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueUnit.Location = new System.Drawing.Point(153, 0);
            this.ValueUnit.Name = "ValueUnit";
            this.ValueUnit.Size = new System.Drawing.Size(31, 17);
            this.ValueUnit.TabIndex = 7;
            this.ValueUnit.Text = "unit";
            // 
            // ValueResult
            // 
            this.ValueResult.AutoSize = true;
            this.ValueResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueResult.Location = new System.Drawing.Point(115, 0);
            this.ValueResult.Name = "ValueResult";
            this.ValueResult.Size = new System.Drawing.Size(13, 17);
            this.ValueResult.TabIndex = 6;
            this.ValueResult.Text = "-";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueLabel.Location = new System.Drawing.Point(3, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(80, 17);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "value_label";
            // 
            // TextGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ValueUnit);
            this.Controls.Add(this.ValueResult);
            this.Controls.Add(this.ValueLabel);
            this.Name = "TextGauge";
            this.Size = new System.Drawing.Size(187, 17);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueUnit;
        private System.Windows.Forms.Label ValueResult;
        private System.Windows.Forms.Label ValueLabel;
    }
}
