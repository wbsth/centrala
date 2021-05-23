
namespace centrala
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.SerialSettingsBox = new System.Windows.Forms.GroupBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SerialSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortComboBox
            // 
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(116, 22);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(121, 21);
            this.PortComboBox.TabIndex = 0;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(15, 25);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(32, 13);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port: ";
            // 
            // SerialSettingsBox
            // 
            this.SerialSettingsBox.Controls.Add(this.SaveSettingsButton);
            this.SerialSettingsBox.Controls.Add(this.StopBitsLabel);
            this.SerialSettingsBox.Controls.Add(this.DataBitsLabel);
            this.SerialSettingsBox.Controls.Add(this.ParityLabel);
            this.SerialSettingsBox.Controls.Add(this.BaudRateLabel);
            this.SerialSettingsBox.Controls.Add(this.PortLabel);
            this.SerialSettingsBox.Controls.Add(this.StopBitsComboBox);
            this.SerialSettingsBox.Controls.Add(this.DataBitsComboBox);
            this.SerialSettingsBox.Controls.Add(this.ParityComboBox);
            this.SerialSettingsBox.Controls.Add(this.BaudRateComboBox);
            this.SerialSettingsBox.Controls.Add(this.PortComboBox);
            this.SerialSettingsBox.Location = new System.Drawing.Point(12, 12);
            this.SerialSettingsBox.Name = "SerialSettingsBox";
            this.SerialSettingsBox.Size = new System.Drawing.Size(254, 220);
            this.SerialSettingsBox.TabIndex = 2;
            this.SerialSettingsBox.TabStop = false;
            this.SerialSettingsBox.Text = "Serial";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(15, 55);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(56, 13);
            this.BaudRateLabel.TabIndex = 1;
            this.BaudRateLabel.Text = "Baud rate:";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(116, 52);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.BaudRateComboBox.TabIndex = 0;
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(15, 85);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(80, 13);
            this.ParityLabel.TabIndex = 1;
            this.ParityLabel.Text = "Bit parzystości.:";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(116, 82);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(121, 21);
            this.ParityComboBox.TabIndex = 0;
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(15, 115);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(65, 13);
            this.DataBitsLabel.TabIndex = 1;
            this.DataBitsLabel.Text = "Bity danych:";
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Location = new System.Drawing.Point(116, 112);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.DataBitsComboBox.TabIndex = 0;
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Location = new System.Drawing.Point(15, 145);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(56, 13);
            this.StopBitsLabel.TabIndex = 1;
            this.StopBitsLabel.Text = "Bity stopu:";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Location = new System.Drawing.Point(116, 142);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.StopBitsComboBox.TabIndex = 0;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(162, 181);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsButton.TabIndex = 2;
            this.SaveSettingsButton.Text = "Zapisz";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 273);
            this.Controls.Add(this.SerialSettingsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SerialSettingsBox.ResumeLayout(false);
            this.SerialSettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.GroupBox SerialSettingsBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.Button SaveSettingsButton;
    }
}