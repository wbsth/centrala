
namespace centrala
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionInfoBox = new System.Windows.Forms.GroupBox();
            this.dataPicture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusPicture = new System.Windows.Forms.PictureBox();
            this.portValue = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.chooseDataGroup = new System.Windows.Forms.GroupBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.logGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalValue = new System.Windows.Forms.NumericUpDown();
            this.intervalCheckbox = new System.Windows.Forms.CheckBox();
            this.valuesGroup = new System.Windows.Forms.GroupBox();
            this.gauge1 = new centrala.Gauge();
            this.graphBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gauge2 = new centrala.Gauge();
            this.gauge3 = new centrala.Gauge();
            this.mainMenuStrip.SuspendLayout();
            this.connectionInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicture)).BeginInit();
            this.chooseDataGroup.SuspendLayout();
            this.logGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).BeginInit();
            this.valuesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1001, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Image = global::centrala.Properties.Resources.Close_16x;
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Image = global::centrala.Properties.Resources.Settings_16x;
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Image = global::centrala.Properties.Resources.InformationSymbol_16x;
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // connectionInfoBox
            // 
            this.connectionInfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.connectionInfoBox.Controls.Add(this.dataPicture);
            this.connectionInfoBox.Controls.Add(this.label3);
            this.connectionInfoBox.Controls.Add(this.pictureBox2);
            this.connectionInfoBox.Controls.Add(this.statusPicture);
            this.connectionInfoBox.Controls.Add(this.portValue);
            this.connectionInfoBox.Controls.Add(this.portLabel);
            this.connectionInfoBox.Location = new System.Drawing.Point(12, 29);
            this.connectionInfoBox.Name = "connectionInfoBox";
            this.connectionInfoBox.Size = new System.Drawing.Size(141, 92);
            this.connectionInfoBox.TabIndex = 2;
            this.connectionInfoBox.TabStop = false;
            this.connectionInfoBox.Text = "Połączenie";
            // 
            // dataPicture
            // 
            this.dataPicture.AutoSize = true;
            this.dataPicture.Location = new System.Drawing.Point(66, 65);
            this.dataPicture.Name = "dataPicture";
            this.dataPicture.Size = new System.Drawing.Size(33, 13);
            this.dataPicture.TabIndex = 6;
            this.dataPicture.Text = "Dane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // statusPicture
            // 
            this.statusPicture.Image = ((System.Drawing.Image)(resources.GetObject("statusPicture.Image")));
            this.statusPicture.Location = new System.Drawing.Point(35, 40);
            this.statusPicture.Name = "statusPicture";
            this.statusPicture.Size = new System.Drawing.Size(16, 16);
            this.statusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusPicture.TabIndex = 4;
            this.statusPicture.TabStop = false;
            // 
            // portValue
            // 
            this.portValue.AutoSize = true;
            this.portValue.Location = new System.Drawing.Point(51, 20);
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(64, 13);
            this.portValue.TabIndex = 1;
            this.portValue.Text = "nie wybrano";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(7, 20);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 326);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(141, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // chooseDataGroup
            // 
            this.chooseDataGroup.Controls.Add(this.checkedListBox);
            this.chooseDataGroup.Location = new System.Drawing.Point(12, 127);
            this.chooseDataGroup.Name = "chooseDataGroup";
            this.chooseDataGroup.Size = new System.Drawing.Size(141, 111);
            this.chooseDataGroup.TabIndex = 3;
            this.chooseDataGroup.TabStop = false;
            this.chooseDataGroup.Text = "Wybór danych";
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.Items.AddRange(new object[] {
            "Wysokość",
            "IAS",
            "TAS",
            "W",
            "Temperatura"});
            this.checkedListBox.Location = new System.Drawing.Point(10, 19);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 90);
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // logGroup
            // 
            this.logGroup.Controls.Add(this.label2);
            this.logGroup.Controls.Add(this.label1);
            this.logGroup.Controls.Add(this.intervalValue);
            this.logGroup.Controls.Add(this.intervalCheckbox);
            this.logGroup.Location = new System.Drawing.Point(12, 244);
            this.logGroup.Name = "logGroup";
            this.logGroup.Size = new System.Drawing.Size(141, 76);
            this.logGroup.TabIndex = 4;
            this.logGroup.TabStop = false;
            this.logGroup.Text = "Logowanie";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interwał:";
            // 
            // intervalValue
            // 
            this.intervalValue.DecimalPlaces = 1;
            this.intervalValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.intervalValue.Location = new System.Drawing.Point(59, 18);
            this.intervalValue.Name = "intervalValue";
            this.intervalValue.Size = new System.Drawing.Size(58, 20);
            this.intervalValue.TabIndex = 1;
            this.intervalValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // intervalCheckbox
            // 
            this.intervalCheckbox.AutoSize = true;
            this.intervalCheckbox.Checked = true;
            this.intervalCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.intervalCheckbox.Location = new System.Drawing.Point(10, 48);
            this.intervalCheckbox.Name = "intervalCheckbox";
            this.intervalCheckbox.Size = new System.Drawing.Size(58, 17);
            this.intervalCheckbox.TabIndex = 0;
            this.intervalCheckbox.Text = "Włącz";
            this.intervalCheckbox.UseVisualStyleBackColor = true;
            // 
            // valuesGroup
            // 
            this.valuesGroup.Controls.Add(this.gauge3);
            this.valuesGroup.Controls.Add(this.gauge2);
            this.valuesGroup.Controls.Add(this.gauge1);
            this.valuesGroup.Location = new System.Drawing.Point(159, 29);
            this.valuesGroup.Name = "valuesGroup";
            this.valuesGroup.Size = new System.Drawing.Size(830, 253);
            this.valuesGroup.TabIndex = 5;
            this.valuesGroup.TabStop = false;
            this.valuesGroup.Text = "Wartości";
            // 
            // gauge1
            // 
            this.gauge1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gauge1.DesignerType = centrala.Gauge.IndicatorTypes.speed;
            this.gauge1.Location = new System.Drawing.Point(18, 19);
            this.gauge1.Name = "gauge1";
            this.gauge1.Size = new System.Drawing.Size(200, 228);
            this.gauge1.TabIndex = 0;
            // 
            // graphBox
            // 
            this.graphBox.Location = new System.Drawing.Point(159, 292);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(830, 317);
            this.graphBox.TabIndex = 6;
            this.graphBox.TabStop = false;
            this.graphBox.Text = "Wykresy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gauge2
            // 
            this.gauge2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gauge2.DesignerType = centrala.Gauge.IndicatorTypes.altitude;
            this.gauge2.Location = new System.Drawing.Point(224, 19);
            this.gauge2.Name = "gauge2";
            this.gauge2.Size = new System.Drawing.Size(200, 228);
            this.gauge2.TabIndex = 0;
            // 
            // gauge3
            // 
            this.gauge3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gauge3.DesignerType = centrala.Gauge.IndicatorTypes.speedVertical;
            this.gauge3.Location = new System.Drawing.Point(430, 19);
            this.gauge3.Name = "gauge3";
            this.gauge3.Size = new System.Drawing.Size(200, 228);
            this.gauge3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.valuesGroup);
            this.Controls.Add(this.logGroup);
            this.Controls.Add(this.chooseDataGroup);
            this.Controls.Add(this.connectionInfoBox);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Centrala aerometryczna";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.connectionInfoBox.ResumeLayout(false);
            this.connectionInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicture)).EndInit();
            this.chooseDataGroup.ResumeLayout(false);
            this.logGroup.ResumeLayout(false);
            this.logGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).EndInit();
            this.valuesGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.GroupBox connectionInfoBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label portValue;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label dataPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox chooseDataGroup;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.GroupBox logGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalValue;
        private System.Windows.Forms.CheckBox intervalCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox valuesGroup;
        private System.Windows.Forms.GroupBox graphBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox statusPicture;
        private Gauge gauge1;
        private System.Windows.Forms.Button button1;
        private Gauge gauge3;
        private Gauge gauge2;
    }
}