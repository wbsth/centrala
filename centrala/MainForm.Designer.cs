
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionInfoBox = new System.Windows.Forms.GroupBox();
            this.DataPictureLabel = new System.Windows.Forms.Label();
            this.StatusPictureLabel = new System.Windows.Forms.Label();
            this.DataPicture = new System.Windows.Forms.PictureBox();
            this.StatusPicture = new System.Windows.Forms.PictureBox();
            this.portValue = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.chooseDataGroup = new System.Windows.Forms.GroupBox();
            this.DataCheckbox = new System.Windows.Forms.CheckedListBox();
            this.logGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalValue = new System.Windows.Forms.NumericUpDown();
            this.intervalCheckbox = new System.Windows.Forms.CheckBox();
            this.valuesGroup = new System.Windows.Forms.GroupBox();
            this.TASTextGauge = new centrala.TextGauge();
            this.TemperatureTextGauge = new centrala.TextGauge();
            this.GaugeVerticalSpeed = new centrala.Gauge();
            this.GaugeAltitude = new centrala.Gauge();
            this.GaugeSpeed = new centrala.Gauge();
            this.chartBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDataChoiceCheckbox = new System.Windows.Forms.CheckedListBox();
            this.chartDataChoiceLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.connectionInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPicture)).BeginInit();
            this.chooseDataGroup.SuspendLayout();
            this.logGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).BeginInit();
            this.valuesGroup.SuspendLayout();
            this.chartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
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
            this.connectionInfoBox.Controls.Add(this.DataPictureLabel);
            this.connectionInfoBox.Controls.Add(this.StatusPictureLabel);
            this.connectionInfoBox.Controls.Add(this.DataPicture);
            this.connectionInfoBox.Controls.Add(this.StatusPicture);
            this.connectionInfoBox.Controls.Add(this.portValue);
            this.connectionInfoBox.Controls.Add(this.portLabel);
            this.connectionInfoBox.Location = new System.Drawing.Point(12, 29);
            this.connectionInfoBox.Name = "connectionInfoBox";
            this.connectionInfoBox.Size = new System.Drawing.Size(141, 92);
            this.connectionInfoBox.TabIndex = 2;
            this.connectionInfoBox.TabStop = false;
            this.connectionInfoBox.Text = "Połączenie";
            // 
            // DataPictureLabel
            // 
            this.DataPictureLabel.AutoSize = true;
            this.DataPictureLabel.Location = new System.Drawing.Point(66, 65);
            this.DataPictureLabel.Name = "DataPictureLabel";
            this.DataPictureLabel.Size = new System.Drawing.Size(33, 13);
            this.DataPictureLabel.TabIndex = 6;
            this.DataPictureLabel.Text = "Dane";
            // 
            // StatusPictureLabel
            // 
            this.StatusPictureLabel.AutoSize = true;
            this.StatusPictureLabel.Location = new System.Drawing.Point(65, 43);
            this.StatusPictureLabel.Name = "StatusPictureLabel";
            this.StatusPictureLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusPictureLabel.TabIndex = 5;
            this.StatusPictureLabel.Text = "Status";
            // 
            // DataPicture
            // 
            this.DataPicture.Image = ((System.Drawing.Image)(resources.GetObject("DataPicture.Image")));
            this.DataPicture.Location = new System.Drawing.Point(35, 62);
            this.DataPicture.Name = "DataPicture";
            this.DataPicture.Size = new System.Drawing.Size(16, 16);
            this.DataPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DataPicture.TabIndex = 4;
            this.DataPicture.TabStop = false;
            // 
            // StatusPicture
            // 
            this.StatusPicture.Image = ((System.Drawing.Image)(resources.GetObject("StatusPicture.Image")));
            this.StatusPicture.Location = new System.Drawing.Point(35, 40);
            this.StatusPicture.Name = "StatusPicture";
            this.StatusPicture.Size = new System.Drawing.Size(16, 16);
            this.StatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusPicture.TabIndex = 4;
            this.StatusPicture.TabStop = false;
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
            this.chooseDataGroup.Controls.Add(this.DataCheckbox);
            this.chooseDataGroup.Location = new System.Drawing.Point(12, 127);
            this.chooseDataGroup.Name = "chooseDataGroup";
            this.chooseDataGroup.Size = new System.Drawing.Size(141, 111);
            this.chooseDataGroup.TabIndex = 3;
            this.chooseDataGroup.TabStop = false;
            this.chooseDataGroup.Text = "Wybór danych";
            // 
            // DataCheckbox
            // 
            this.DataCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.DataCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataCheckbox.CheckOnClick = true;
            this.DataCheckbox.Items.AddRange(new object[] {
            "IAS",
            "Wysokość",
            "W",
            "Temperatura",
            "TAS"});
            this.DataCheckbox.Location = new System.Drawing.Point(10, 19);
            this.DataCheckbox.Name = "DataCheckbox";
            this.DataCheckbox.Size = new System.Drawing.Size(120, 90);
            this.DataCheckbox.TabIndex = 0;
            this.DataCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
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
            this.valuesGroup.Controls.Add(this.TASTextGauge);
            this.valuesGroup.Controls.Add(this.TemperatureTextGauge);
            this.valuesGroup.Controls.Add(this.GaugeVerticalSpeed);
            this.valuesGroup.Controls.Add(this.GaugeAltitude);
            this.valuesGroup.Controls.Add(this.GaugeSpeed);
            this.valuesGroup.Location = new System.Drawing.Point(159, 29);
            this.valuesGroup.Name = "valuesGroup";
            this.valuesGroup.Size = new System.Drawing.Size(830, 253);
            this.valuesGroup.TabIndex = 5;
            this.valuesGroup.TabStop = false;
            this.valuesGroup.Text = "Wartości";
            // 
            // TASTextGauge
            // 
            this.TASTextGauge.AutoSize = true;
            this.TASTextGauge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TASTextGauge.GaugeType = centrala.TextGauge.TextGaugesTypes.TAS;
            this.TASTextGauge.Location = new System.Drawing.Point(636, 143);
            this.TASTextGauge.Name = "TASTextGauge";
            this.TASTextGauge.Size = new System.Drawing.Size(186, 17);
            this.TASTextGauge.TabIndex = 0;
            this.TASTextGauge.ValLabel = "TAS: ";
            this.TASTextGauge.ValUnit = "m/s";
            this.TASTextGauge.ValValue = 0D;
            // 
            // TemperatureTextGauge
            // 
            this.TemperatureTextGauge.AutoSize = true;
            this.TemperatureTextGauge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TemperatureTextGauge.GaugeType = centrala.TextGauge.TextGaugesTypes.temperature;
            this.TemperatureTextGauge.Location = new System.Drawing.Point(636, 117);
            this.TemperatureTextGauge.Name = "TemperatureTextGauge";
            this.TemperatureTextGauge.Size = new System.Drawing.Size(179, 17);
            this.TemperatureTextGauge.TabIndex = 0;
            this.TemperatureTextGauge.ValLabel = "Temperatura: ";
            this.TemperatureTextGauge.ValUnit = "°C";
            this.TemperatureTextGauge.ValValue = 0D;
            // 
            // GaugeVerticalSpeed
            // 
            this.GaugeVerticalSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GaugeVerticalSpeed.DesignerType = centrala.Gauge.IndicatorTypes.speedVertical;
            this.GaugeVerticalSpeed.GaugeValue = 0D;
            this.GaugeVerticalSpeed.Location = new System.Drawing.Point(430, 19);
            this.GaugeVerticalSpeed.Name = "GaugeVerticalSpeed";
            this.GaugeVerticalSpeed.Size = new System.Drawing.Size(200, 228);
            this.GaugeVerticalSpeed.TabIndex = 0;
            // 
            // GaugeAltitude
            // 
            this.GaugeAltitude.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GaugeAltitude.DesignerType = centrala.Gauge.IndicatorTypes.altitude;
            this.GaugeAltitude.GaugeValue = 0D;
            this.GaugeAltitude.Location = new System.Drawing.Point(224, 19);
            this.GaugeAltitude.Name = "GaugeAltitude";
            this.GaugeAltitude.Size = new System.Drawing.Size(200, 228);
            this.GaugeAltitude.TabIndex = 0;
            // 
            // GaugeSpeed
            // 
            this.GaugeSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GaugeSpeed.DesignerType = centrala.Gauge.IndicatorTypes.speed;
            this.GaugeSpeed.GaugeValue = 0D;
            this.GaugeSpeed.Location = new System.Drawing.Point(18, 19);
            this.GaugeSpeed.Name = "GaugeSpeed";
            this.GaugeSpeed.Size = new System.Drawing.Size(200, 228);
            this.GaugeSpeed.TabIndex = 0;
            // 
            // chartBox
            // 
            this.chartBox.Controls.Add(this.chartDataChoiceLabel);
            this.chartBox.Controls.Add(this.chartDataChoiceCheckbox);
            this.chartBox.Controls.Add(this.mainChart);
            this.chartBox.Location = new System.Drawing.Point(159, 292);
            this.chartBox.Name = "chartBox";
            this.chartBox.Size = new System.Drawing.Size(830, 317);
            this.chartBox.TabIndex = 6;
            this.chartBox.TabStop = false;
            this.chartBox.Text = "Wykresy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainChart
            // 
            chartArea4.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.mainChart.Legends.Add(legend4);
            this.mainChart.Location = new System.Drawing.Point(18, 34);
            this.mainChart.Name = "mainChart";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Enabled = false;
            series16.Legend = "Legend1";
            series16.Name = "SpeedIAS";
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Enabled = false;
            series17.Legend = "Legend1";
            series17.Name = "Altitude";
            series18.BorderWidth = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Enabled = false;
            series18.Legend = "Legend1";
            series18.Name = "SpeedVertical";
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Enabled = false;
            series19.Legend = "Legend1";
            series19.Name = "Temperature";
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Enabled = false;
            series20.Legend = "Legend1";
            series20.Name = "SpeedTAS";
            this.mainChart.Series.Add(series16);
            this.mainChart.Series.Add(series17);
            this.mainChart.Series.Add(series18);
            this.mainChart.Series.Add(series19);
            this.mainChart.Series.Add(series20);
            this.mainChart.Size = new System.Drawing.Size(612, 264);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // chartDataChoiceCheckbox
            // 
            this.chartDataChoiceCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.chartDataChoiceCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartDataChoiceCheckbox.CheckOnClick = true;
            this.chartDataChoiceCheckbox.Items.AddRange(new object[] {
            "IAS",
            "Wysokość",
            "W",
            "Temperatura",
            "TAS"});
            this.chartDataChoiceCheckbox.Location = new System.Drawing.Point(664, 139);
            this.chartDataChoiceCheckbox.Name = "chartDataChoiceCheckbox";
            this.chartDataChoiceCheckbox.Size = new System.Drawing.Size(120, 90);
            this.chartDataChoiceCheckbox.TabIndex = 0;
            this.chartDataChoiceCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chartDataChoiceCheckbox_ItemCheck);
            // 
            // chartDataChoiceLabel
            // 
            this.chartDataChoiceLabel.AutoSize = true;
            this.chartDataChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartDataChoiceLabel.Location = new System.Drawing.Point(647, 121);
            this.chartDataChoiceLabel.Name = "chartDataChoiceLabel";
            this.chartDataChoiceLabel.Size = new System.Drawing.Size(124, 15);
            this.chartDataChoiceLabel.TabIndex = 1;
            this.chartDataChoiceLabel.Text = "Dane na wykresie:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 621);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPicture)).EndInit();
            this.chooseDataGroup.ResumeLayout(false);
            this.logGroup.ResumeLayout(false);
            this.logGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalValue)).EndInit();
            this.valuesGroup.ResumeLayout(false);
            this.valuesGroup.PerformLayout();
            this.chartBox.ResumeLayout(false);
            this.chartBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
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
        private System.Windows.Forms.Label DataPictureLabel;
        private System.Windows.Forms.Label StatusPictureLabel;
        private System.Windows.Forms.GroupBox chooseDataGroup;
        private System.Windows.Forms.CheckedListBox DataCheckbox;
        private System.Windows.Forms.GroupBox logGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalValue;
        private System.Windows.Forms.CheckBox intervalCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox valuesGroup;
        private System.Windows.Forms.GroupBox chartBox;
        private System.Windows.Forms.PictureBox DataPicture;
        private System.Windows.Forms.PictureBox StatusPicture;
        private Gauge GaugeSpeed;
        private System.Windows.Forms.Button button1;
        private Gauge GaugeVerticalSpeed;
        private Gauge GaugeAltitude;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private TextGauge TASTextGauge;
        private TextGauge TemperatureTextGauge;
        private System.Windows.Forms.Label chartDataChoiceLabel;
        private System.Windows.Forms.CheckedListBox chartDataChoiceCheckbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
    }
}