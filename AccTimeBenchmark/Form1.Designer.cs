namespace AccTimeBenchmark
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 1230D);
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBoxDisk = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            this.checkBoxFullSeq = new System.Windows.Forms.CheckBox();
            this.checkBoxThread = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSceRes = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeqResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA4kResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxScenario = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txt4kResult = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThreads = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chartFullSeq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelSysversion = new System.Windows.Forms.Label();
            this.labelcpu = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFullSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDisk
            // 
            this.comboBoxDisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisk.FormattingEnabled = true;
            this.comboBoxDisk.Location = new System.Drawing.Point(82, 146);
            this.comboBoxDisk.Name = "comboBoxDisk";
            this.comboBoxDisk.Size = new System.Drawing.Size(564, 38);
            this.comboBoxDisk.TabIndex = 54;
            this.comboBoxDisk.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisk_SelectedIndexChanged);
            this.comboBoxDisk.MouseHover += new System.EventHandler(this.comboBoxDisk_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxFast);
            this.groupBox2.Controls.Add(this.checkBoxFullSeq);
            this.groupBox2.Controls.Add(this.checkBoxThread);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.checkBoxScenario);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(42, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(646, 507);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "性能测试";
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Checked = true;
            this.checkBoxFast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFast.Location = new System.Drawing.Point(42, 40);
            this.checkBoxFast.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(133, 34);
            this.checkBoxFast.TabIndex = 5;
            this.checkBoxFast.Text = "快速测试";
            this.checkBoxFast.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullSeq
            // 
            this.checkBoxFullSeq.AutoSize = true;
            this.checkBoxFullSeq.Location = new System.Drawing.Point(42, 84);
            this.checkBoxFullSeq.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxFullSeq.Name = "checkBoxFullSeq";
            this.checkBoxFullSeq.Size = new System.Drawing.Size(133, 34);
            this.checkBoxFullSeq.TabIndex = 6;
            this.checkBoxFullSeq.Text = "全盘写入";
            this.checkBoxFullSeq.UseVisualStyleBackColor = true;
            // 
            // checkBoxThread
            // 
            this.checkBoxThread.AutoSize = true;
            this.checkBoxThread.Checked = true;
            this.checkBoxThread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxThread.Location = new System.Drawing.Point(198, 40);
            this.checkBoxThread.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxThread.Name = "checkBoxThread";
            this.checkBoxThread.Size = new System.Drawing.Size(189, 34);
            this.checkBoxThread.TabIndex = 4;
            this.checkBoxThread.Text = "多线程(6mins)";
            this.checkBoxThread.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(42, 144);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(562, 26);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelSceRes);
            this.groupBox3.Controls.Add(this.labelLevel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSeqResult);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtA4kResult);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(0, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(646, 298);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "场景测试(v1.0)";
            // 
            // labelSceRes
            // 
            this.labelSceRes.AutoSize = true;
            this.labelSceRes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSceRes.Location = new System.Drawing.Point(205, 237);
            this.labelSceRes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSceRes.Name = "labelSceRes";
            this.labelSceRes.Size = new System.Drawing.Size(24, 31);
            this.labelSceRes.TabIndex = 10;
            this.labelSceRes.Text = "-";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Black;
            this.labelLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLevel.Location = new System.Drawing.Point(213, 166);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(0, 51);
            this.labelLevel.TabIndex = 9;
            this.labelLevel.Click += new System.EventHandler(this.labelLevel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "等级";
            // 
            // txtSeqResult
            // 
            this.txtSeqResult.Location = new System.Drawing.Point(211, 48);
            this.txtSeqResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtSeqResult.Name = "txtSeqResult";
            this.txtSeqResult.ReadOnly = true;
            this.txtSeqResult.Size = new System.Drawing.Size(382, 36);
            this.txtSeqResult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "连续写入";
            // 
            // txtA4kResult
            // 
            this.txtA4kResult.Location = new System.Drawing.Point(211, 101);
            this.txtA4kResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtA4kResult.Name = "txtA4kResult";
            this.txtA4kResult.ReadOnly = true;
            this.txtA4kResult.Size = new System.Drawing.Size(382, 36);
            this.txtA4kResult.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "4K随机写入";
            // 
            // checkBoxScenario
            // 
            this.checkBoxScenario.AutoSize = true;
            this.checkBoxScenario.Checked = true;
            this.checkBoxScenario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScenario.Location = new System.Drawing.Point(198, 84);
            this.checkBoxScenario.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxScenario.Name = "checkBoxScenario";
            this.checkBoxScenario.Size = new System.Drawing.Size(224, 34);
            this.checkBoxScenario.TabIndex = 3;
            this.checkBoxScenario.Text = "场景测试(15mins)";
            this.checkBoxScenario.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(492, 40);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 70);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt4kResult
            // 
            this.txt4kResult.Location = new System.Drawing.Point(264, 717);
            this.txt4kResult.Margin = new System.Windows.Forms.Padding(6);
            this.txt4kResult.Name = "txt4kResult";
            this.txt4kResult.ReadOnly = true;
            this.txt4kResult.Size = new System.Drawing.Size(382, 36);
            this.txt4kResult.TabIndex = 1;
            this.txt4kResult.Visible = false;
            // 
            // chart1
            // 
            chartArea9.AxisX.Interval = 5D;
            chartArea9.AxisX.Maximum = 15D;
            chartArea9.AxisX.Minimum = 0D;
            chartArea9.AxisX.Title = "时间(s)";
            chartArea9.AxisY.Title = "MB/s";
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Location = new System.Drawing.Point(714, 48);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(483, 662);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title9.Name = "Title1";
            title9.Text = "4K随机写入速度";
            this.chart1.Titles.Add(title9);
            // 
            // chartThreads
            // 
            chartArea10.AxisX.Interval = 1D;
            chartArea10.AxisX.IsLogarithmic = true;
            chartArea10.AxisX.LogarithmBase = 2D;
            chartArea10.AxisX.Maximum = 32D;
            chartArea10.AxisX.Minimum = 1D;
            chartArea10.AxisX.Title = "Threads";
            chartArea10.AxisY.Title = "MB/s";
            chartArea10.Name = "ChartArea1";
            this.chartThreads.ChartAreas.Add(chartArea10);
            this.chartThreads.Location = new System.Drawing.Point(1245, 48);
            this.chartThreads.Name = "chartThreads";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series10.Name = "Series1";
            series10.Points.Add(dataPoint5);
            this.chartThreads.Series.Add(series10);
            this.chartThreads.Size = new System.Drawing.Size(483, 662);
            this.chartThreads.TabIndex = 13;
            this.chartThreads.Text = "chart2";
            title10.Name = "Title1";
            title10.Text = "4K随机写入速度-线程数";
            this.chartThreads.Titles.Add(title10);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(714, 651);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(1245, 651);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chartFullSeq
            // 
            chartArea11.AxisX.Minimum = 0D;
            chartArea11.AxisX.Title = "写入量(GB)";
            chartArea11.AxisY.Minimum = 0D;
            chartArea11.AxisY.Title = "MB/s";
            chartArea11.Name = "ChartArea1";
            this.chartFullSeq.ChartAreas.Add(chartArea11);
            this.chartFullSeq.Location = new System.Drawing.Point(42, 766);
            this.chartFullSeq.Name = "chartFullSeq";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series11.Name = "Series1";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartFullSeq.Series.Add(series11);
            this.chartFullSeq.Size = new System.Drawing.Size(1686, 410);
            this.chartFullSeq.TabIndex = 52;
            this.chartFullSeq.Text = "chart2";
            title11.Name = "Title1";
            title11.Text = "全盘连续写入";
            this.chartFullSeq.Titles.Add(title11);
            this.chartFullSeq.Click += new System.EventHandler(this.chartFullSeq_Click);
            // 
            // chart2
            // 
            chartArea12.AxisX.Interval = 1D;
            chartArea12.AxisX.LogarithmBase = 2D;
            chartArea12.AxisX.Maximum = 10D;
            chartArea12.AxisX.Minimum = 1D;
            chartArea12.AxisX.Title = "Threads";
            chartArea12.AxisY.Title = "MB/s";
            chartArea12.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea12);
            this.chart2.Location = new System.Drawing.Point(21, 766);
            this.chart2.Name = "chart2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series12.Name = "Series1";
            dataPoint6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint6.IsValueShownAsLabel = false;
            dataPoint6.Label = "CHIPFANCIER Pro 256GB";
            dataPoint6.LabelForeColor = System.Drawing.Color.White;
            series12.Points.Add(dataPoint6);
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(646, 418);
            this.chart2.TabIndex = 53;
            this.chart2.Text = "chart2";
            title12.Name = "Title1";
            title12.Text = "4K随机写入速度-线程数";
            this.chart2.Titles.Add(title12);
            this.chart2.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(42, 1183);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 30);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.Visible = false;
            // 
            // labelSysversion
            // 
            this.labelSysversion.AutoSize = true;
            this.labelSysversion.Location = new System.Drawing.Point(77, 48);
            this.labelSysversion.Name = "labelSysversion";
            this.labelSysversion.Size = new System.Drawing.Size(127, 30);
            this.labelSysversion.TabIndex = 1;
            this.labelSysversion.Text = "SysVersion";
            // 
            // labelcpu
            // 
            this.labelcpu.AutoSize = true;
            this.labelcpu.Location = new System.Drawing.Point(77, 95);
            this.labelcpu.Name = "labelcpu";
            this.labelcpu.Size = new System.Drawing.Size(57, 30);
            this.labelcpu.TabIndex = 2;
            this.labelcpu.Text = "CPU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2284, 1234);
            this.Controls.Add(this.labelcpu);
            this.Controls.Add(this.comboBoxDisk);
            this.Controls.Add(this.labelSysversion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chartFullSeq);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chartThreads);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt4kResult);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WTGBench ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFullSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt4kResult;
        private System.Windows.Forms.TextBox txtSeqResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA4kResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBoxScenario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThreads;
        private System.Windows.Forms.CheckBox checkBoxThread;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxFast;
        private System.Windows.Forms.CheckBox checkBoxFullSeq;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFullSeq;
        private System.Windows.Forms.Label labelSceRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox comboBoxDisk;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelSysversion;
        private System.Windows.Forms.Label labelcpu;
    }
}

