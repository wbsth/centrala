
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.intervalCheckbox = new System.Windows.Forms.CheckBox();
            this.valuesGroup = new System.Windows.Forms.GroupBox();
            this.chartBox = new System.Windows.Forms.GroupBox();
            this.ClearChartButton = new System.Windows.Forms.Button();
            this.chartDataChoiceLabel = new System.Windows.Forms.Label();
            this.chartDataChoiceCheckbox = new System.Windows.Forms.CheckedListBox();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TASTextGauge = new centrala.TextGauge();
            this.TemperatureTextGauge = new centrala.TextGauge();
            this.GaugeVerticalSpeed = new centrala.Gauge();
            this.GaugeAltitude = new centrala.Gauge();
            this.GaugeSpeed = new centrala.Gauge();
            this.mainMenuStrip.SuspendLayout();
            this.connectionInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPicture)).BeginInit();
            this.chooseDataGroup.SuspendLayout();
            this.logGroup.SuspendLayout();
            this.valuesGroup.SuspendLayout();
            this.chartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1335, 30);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Image = global::centrala.Properties.Resources.Close_16x;
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Image = global::centrala.Properties.Resources.Settings_16x;
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Image = global::centrala.Properties.Resources.InformationSymbol_16x;
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
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
            this.connectionInfoBox.Location = new System.Drawing.Point(16, 36);
            this.connectionInfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionInfoBox.Name = "connectionInfoBox";
            this.connectionInfoBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionInfoBox.Size = new System.Drawing.Size(188, 113);
            this.connectionInfoBox.TabIndex = 2;
            this.connectionInfoBox.TabStop = false;
            this.connectionInfoBox.Text = "Połączenie";
            // 
            // DataPictureLabel
            // 
            this.DataPictureLabel.AutoSize = true;
            this.DataPictureLabel.Location = new System.Drawing.Point(88, 80);
            this.DataPictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataPictureLabel.Name = "DataPictureLabel";
            this.DataPictureLabel.Size = new System.Drawing.Size(42, 17);
            this.DataPictureLabel.TabIndex = 6;
            this.DataPictureLabel.Text = "Dane";
            // 
            // StatusPictureLabel
            // 
            this.StatusPictureLabel.AutoSize = true;
            this.StatusPictureLabel.Location = new System.Drawing.Point(87, 53);
            this.StatusPictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusPictureLabel.Name = "StatusPictureLabel";
            this.StatusPictureLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusPictureLabel.TabIndex = 5;
            this.StatusPictureLabel.Text = "Status";
            // 
            // DataPicture
            // 
            this.DataPicture.Image = ((System.Drawing.Image)(resources.GetObject("DataPicture.Image")));
            this.DataPicture.Location = new System.Drawing.Point(47, 76);
            this.DataPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataPicture.Name = "DataPicture";
            this.DataPicture.Size = new System.Drawing.Size(21, 20);
            this.DataPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DataPicture.TabIndex = 4;
            this.DataPicture.TabStop = false;
            // 
            // StatusPicture
            // 
            this.StatusPicture.Image = ((System.Drawing.Image)(resources.GetObject("StatusPicture.Image")));
            this.StatusPicture.Location = new System.Drawing.Point(47, 49);
            this.StatusPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusPicture.Name = "StatusPicture";
            this.StatusPicture.Size = new System.Drawing.Size(21, 20);
            this.StatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusPicture.TabIndex = 4;
            this.StatusPicture.TabStop = false;
            // 
            // portValue
            // 
            this.portValue.AutoSize = true;
            this.portValue.Location = new System.Drawing.Point(68, 25);
            this.portValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(84, 17);
            this.portValue.TabIndex = 1;
            this.portValue.Text = "nie wybrano";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(9, 25);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 17);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(16, 369);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(188, 28);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // chooseDataGroup
            // 
            this.chooseDataGroup.Controls.Add(this.DataCheckbox);
            this.chooseDataGroup.Location = new System.Drawing.Point(16, 156);
            this.chooseDataGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseDataGroup.Name = "chooseDataGroup";
            this.chooseDataGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseDataGroup.Size = new System.Drawing.Size(188, 137);
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
            this.DataCheckbox.Location = new System.Drawing.Point(13, 23);
            this.DataCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataCheckbox.Name = "DataCheckbox";
            this.DataCheckbox.Size = new System.Drawing.Size(160, 102);
            this.DataCheckbox.TabIndex = 0;
            this.DataCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // logGroup
            // 
            this.logGroup.Controls.Add(this.intervalCheckbox);
            this.logGroup.Location = new System.Drawing.Point(16, 300);
            this.logGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logGroup.Name = "logGroup";
            this.logGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logGroup.Size = new System.Drawing.Size(188, 62);
            this.logGroup.TabIndex = 4;
            this.logGroup.TabStop = false;
            this.logGroup.Text = "Logowanie";
            // 
            // intervalCheckbox
            // 
            this.intervalCheckbox.AutoSize = true;
            this.intervalCheckbox.Checked = true;
            this.intervalCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.intervalCheckbox.Location = new System.Drawing.Point(8, 26);
            this.intervalCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.intervalCheckbox.Name = "intervalCheckbox";
            this.intervalCheckbox.Size = new System.Drawing.Size(68, 21);
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
            this.valuesGroup.Location = new System.Drawing.Point(212, 36);
            this.valuesGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valuesGroup.Name = "valuesGroup";
            this.valuesGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valuesGroup.Size = new System.Drawing.Size(1107, 311);
            this.valuesGroup.TabIndex = 5;
            this.valuesGroup.TabStop = false;
            this.valuesGroup.Text = "Wartości";
            // 
            // chartBox
            // 
            this.chartBox.Controls.Add(this.ClearChartButton);
            this.chartBox.Controls.Add(this.chartDataChoiceLabel);
            this.chartBox.Controls.Add(this.chartDataChoiceCheckbox);
            this.chartBox.Controls.Add(this.mainChart);
            this.chartBox.Location = new System.Drawing.Point(212, 359);
            this.chartBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartBox.Name = "chartBox";
            this.chartBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartBox.Size = new System.Drawing.Size(1107, 390);
            this.chartBox.TabIndex = 6;
            this.chartBox.TabStop = false;
            this.chartBox.Text = "Wykresy";
            // 
            // ClearChartButton
            // 
            this.ClearChartButton.Location = new System.Drawing.Point(884, 247);
            this.ClearChartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearChartButton.Name = "ClearChartButton";
            this.ClearChartButton.Size = new System.Drawing.Size(161, 28);
            this.ClearChartButton.TabIndex = 2;
            this.ClearChartButton.Text = "Wyczyść wykres";
            this.ClearChartButton.UseVisualStyleBackColor = true;
            this.ClearChartButton.Click += new System.EventHandler(this.ClearChartButton_Click);
            // 
            // chartDataChoiceLabel
            // 
            this.chartDataChoiceLabel.AutoSize = true;
            this.chartDataChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartDataChoiceLabel.Location = new System.Drawing.Point(880, 107);
            this.chartDataChoiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartDataChoiceLabel.Name = "chartDataChoiceLabel";
            this.chartDataChoiceLabel.Size = new System.Drawing.Size(146, 18);
            this.chartDataChoiceLabel.TabIndex = 1;
            this.chartDataChoiceLabel.Text = "Dane na wykresie:";
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
            this.chartDataChoiceCheckbox.Location = new System.Drawing.Point(900, 129);
            this.chartDataChoiceCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDataChoiceCheckbox.Name = "chartDataChoiceCheckbox";
            this.chartDataChoiceCheckbox.Size = new System.Drawing.Size(160, 102);
            this.chartDataChoiceCheckbox.TabIndex = 0;
            this.chartDataChoiceCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chartDataChoiceCheckbox_ItemCheck);
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(24, 42);
            this.mainChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainChart.Name = "mainChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "SpeedIAS";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.Name = "Altitude";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "SpeedVertical";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.Name = "Temperature";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Enabled = false;
            series5.Legend = "Legend1";
            series5.Name = "SpeedTAS";
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Series.Add(series3);
            this.mainChart.Series.Add(series4);
            this.mainChart.Series.Add(series5);
            this.mainChart.Size = new System.Drawing.Size(816, 325);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // TASTextGauge
            // 
            this.TASTextGauge.AutoSize = true;
            this.TASTextGauge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TASTextGauge.GaugeType = centrala.TextGauge.TextGaugesTypes.TAS;
            this.TASTextGauge.Location = new System.Drawing.Point(848, 176);
            this.TASTextGauge.Margin = new System.Windows.Forms.Padding(5);
            this.TASTextGauge.Name = "TASTextGauge";
            this.TASTextGauge.Size = new System.Drawing.Size(253, 20);
            this.TASTextGauge.TabIndex = 0;
            this.TASTextGauge.ValLabel = "TAS: ";
            this.TASTextGauge.ValUnit = "km/h";
            this.TASTextGauge.ValValue = 0D;
            // 
            // TemperatureTextGauge
            // 
            this.TemperatureTextGauge.AutoSize = true;
            this.TemperatureTextGauge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TemperatureTextGauge.GaugeType = centrala.TextGauge.TextGaugesTypes.temperature;
            this.TemperatureTextGauge.Location = new System.Drawing.Point(848, 144);
            this.TemperatureTextGauge.Margin = new System.Windows.Forms.Padding(5);
            this.TemperatureTextGauge.Name = "TemperatureTextGauge";
            this.TemperatureTextGauge.Size = new System.Drawing.Size(236, 20);
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
            this.GaugeVerticalSpeed.Location = new System.Drawing.Point(573, 23);
            this.GaugeVerticalSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.GaugeVerticalSpeed.Name = "GaugeVerticalSpeed";
            this.GaugeVerticalSpeed.Size = new System.Drawing.Size(267, 281);
            this.GaugeVerticalSpeed.TabIndex = 0;
            // 
            // GaugeAltitude
            // 
            this.GaugeAltitude.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GaugeAltitude.DesignerType = centrala.Gauge.IndicatorTypes.altitude;
            this.GaugeAltitude.GaugeValue = 0D;
            this.GaugeAltitude.Location = new System.Drawing.Point(299, 23);
            this.GaugeAltitude.Margin = new System.Windows.Forms.Padding(5);
            this.GaugeAltitude.Name = "GaugeAltitude";
            this.GaugeAltitude.Size = new System.Drawing.Size(267, 281);
            this.GaugeAltitude.TabIndex = 0;
            // 
            // GaugeSpeed
            // 
            this.GaugeSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GaugeSpeed.DesignerType = centrala.Gauge.IndicatorTypes.speed;
            this.GaugeSpeed.GaugeValue = 0D;
            this.GaugeSpeed.Location = new System.Drawing.Point(24, 23);
            this.GaugeSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.GaugeSpeed.Name = "GaugeSpeed";
            this.GaugeSpeed.Size = new System.Drawing.Size(267, 281);
            this.GaugeSpeed.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 764);
            this.Controls.Add(this.chartBox);
            this.Controls.Add(this.valuesGroup);
            this.Controls.Add(this.logGroup);
            this.Controls.Add(this.chooseDataGroup);
            this.Controls.Add(this.connectionInfoBox);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Centrala aerometryczna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.CheckBox intervalCheckbox;
        private System.Windows.Forms.GroupBox valuesGroup;
        private System.Windows.Forms.GroupBox chartBox;
        private System.Windows.Forms.PictureBox DataPicture;
        private System.Windows.Forms.PictureBox StatusPicture;
        private Gauge GaugeSpeed;
        private Gauge GaugeVerticalSpeed;
        private Gauge GaugeAltitude;
        private TextGauge TASTextGauge;
        private TextGauge TemperatureTextGauge;
        private System.Windows.Forms.Label chartDataChoiceLabel;
        private System.Windows.Forms.CheckedListBox chartDataChoiceCheckbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button ClearChartButton;
    }
}