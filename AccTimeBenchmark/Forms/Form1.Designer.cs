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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBoxDisk = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            this.checkBoxFullSeq = new System.Windows.Forms.CheckBox();
            this.checkBoxThread = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxL1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxL2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxL3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxL4 = new System.Windows.Forms.PictureBox();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelSysversion = new System.Windows.Forms.Label();
            this.labelcpu = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFullSeq)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDisk
            // 
            this.comboBoxDisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisk.FormattingEnabled = true;
            this.comboBoxDisk.Location = new System.Drawing.Point(55, 93);
            this.comboBoxDisk.Name = "comboBoxDisk";
            this.comboBoxDisk.Size = new System.Drawing.Size(376, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(28, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(431, 338);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "性能测试";
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Checked = true;
            this.checkBoxFast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFast.Location = new System.Drawing.Point(28, 27);
            this.checkBoxFast.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(89, 23);
            this.checkBoxFast.TabIndex = 5;
            this.checkBoxFast.Text = "快速测试";
            this.checkBoxFast.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullSeq
            // 
            this.checkBoxFullSeq.AutoSize = true;
            this.checkBoxFullSeq.Checked = true;
            this.checkBoxFullSeq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFullSeq.Location = new System.Drawing.Point(28, 56);
            this.checkBoxFullSeq.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxFullSeq.Name = "checkBoxFullSeq";
            this.checkBoxFullSeq.Size = new System.Drawing.Size(89, 23);
            this.checkBoxFullSeq.TabIndex = 6;
            this.checkBoxFullSeq.Text = "全盘写入";
            this.checkBoxFullSeq.UseVisualStyleBackColor = true;
            // 
            // checkBoxThread
            // 
            this.checkBoxThread.AutoSize = true;
            this.checkBoxThread.Checked = true;
            this.checkBoxThread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxThread.Location = new System.Drawing.Point(132, 27);
            this.checkBoxThread.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxThread.Name = "checkBoxThread";
            this.checkBoxThread.Size = new System.Drawing.Size(126, 23);
            this.checkBoxThread.TabIndex = 4;
            this.checkBoxThread.Text = "多线程(6mins)";
            this.checkBoxThread.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 96);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 17);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxL1);
            this.groupBox3.Controls.Add(this.pictureBoxL2);
            this.groupBox3.Controls.Add(this.pictureBoxL3);
            this.groupBox3.Controls.Add(this.pictureBoxL4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelSceRes);
            this.groupBox3.Controls.Add(this.labelLevel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSeqResult);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtA4kResult);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(0, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(431, 199);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
            // 
            // pictureBoxL1
            // 
            this.pictureBoxL1.Image = global::AccTimeBenchmark.Properties.Resources.orange;
            this.pictureBoxL1.Location = new System.Drawing.Point(271, 111);
            this.pictureBoxL1.Name = "pictureBoxL1";
            this.pictureBoxL1.Size = new System.Drawing.Size(28, 33);
            this.pictureBoxL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL1.TabIndex = 15;
            this.pictureBoxL1.TabStop = false;
            this.pictureBoxL1.Visible = false;
            // 
            // pictureBoxL2
            // 
            this.pictureBoxL2.Image = global::AccTimeBenchmark.Properties.Resources.grey;
            this.pictureBoxL2.Location = new System.Drawing.Point(303, 111);
            this.pictureBoxL2.Name = "pictureBoxL2";
            this.pictureBoxL2.Size = new System.Drawing.Size(28, 33);
            this.pictureBoxL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL2.TabIndex = 14;
            this.pictureBoxL2.TabStop = false;
            this.pictureBoxL2.Visible = false;
            // 
            // pictureBoxL3
            // 
            this.pictureBoxL3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxL3.Image")));
            this.pictureBoxL3.Location = new System.Drawing.Point(335, 111);
            this.pictureBoxL3.Name = "pictureBoxL3";
            this.pictureBoxL3.Size = new System.Drawing.Size(28, 33);
            this.pictureBoxL3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL3.TabIndex = 13;
            this.pictureBoxL3.TabStop = false;
            this.pictureBoxL3.Visible = false;
            // 
            // pictureBoxL4
            // 
            this.pictureBoxL4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxL4.Image")));
            this.pictureBoxL4.Location = new System.Drawing.Point(367, 111);
            this.pictureBoxL4.Name = "pictureBoxL4";
            this.pictureBoxL4.Size = new System.Drawing.Size(28, 33);
            this.pictureBoxL4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxL4.TabIndex = 12;
            this.pictureBoxL4.TabStop = false;
            this.pictureBoxL4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "场景测试(v1.0)";
            // 
            // labelSceRes
            // 
            this.labelSceRes.AutoSize = true;
            this.labelSceRes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSceRes.Location = new System.Drawing.Point(136, 156);
            this.labelSceRes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSceRes.Name = "labelSceRes";
            this.labelSceRes.Size = new System.Drawing.Size(16, 21);
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
            this.labelLevel.Location = new System.Drawing.Point(135, 111);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(133, 34);
            this.labelLevel.TabIndex = 9;
            this.labelLevel.Text = "Platinum";
            this.labelLevel.Visible = false;
            this.labelLevel.Click += new System.EventHandler(this.labelLevel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);/////////
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "等级";
            // 
            // txtSeqResult
            // 
            this.txtSeqResult.Location = new System.Drawing.Point(132, 32);
            this.txtSeqResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeqResult.Name = "txtSeqResult";
            this.txtSeqResult.ReadOnly = true;
            this.txtSeqResult.Size = new System.Drawing.Size(263, 24);
            this.txtSeqResult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "连续写入";
            // 
            // txtA4kResult
            // 
            this.txtA4kResult.Location = new System.Drawing.Point(132, 67);
            this.txtA4kResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtA4kResult.Name = "txtA4kResult";
            this.txtA4kResult.ReadOnly = true;
            this.txtA4kResult.Size = new System.Drawing.Size(263, 24);
            this.txtA4kResult.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "4K随机写入";
            // 
            // checkBoxScenario
            // 
            this.checkBoxScenario.AutoSize = true;
            this.checkBoxScenario.Checked = true;
            this.checkBoxScenario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScenario.Location = new System.Drawing.Point(132, 56);
            this.checkBoxScenario.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxScenario.Name = "checkBoxScenario";
            this.checkBoxScenario.Size = new System.Drawing.Size(149, 23);
            this.checkBoxScenario.TabIndex = 3;
            this.checkBoxScenario.Text = "场景测试(15mins)";
            this.checkBoxScenario.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(328, 27);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt4kResult
            // 
            this.txt4kResult.Location = new System.Drawing.Point(75, 527);
            this.txt4kResult.Margin = new System.Windows.Forms.Padding(6);
            this.txt4kResult.Name = "txt4kResult";
            this.txt4kResult.ReadOnly = true;
            this.txt4kResult.Size = new System.Drawing.Size(255, 24);
            this.txt4kResult.TabIndex = 1;
            this.txt4kResult.Visible = false;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.Maximum = 15D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "时间(s)";
            chartArea1.AxisY.Title = "MB/s";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(476, 32);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(322, 440);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "4K随机写入速度";
            this.chart1.Titles.Add(title1);
            // 
            // chartThreads
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsLogarithmic = true;
            chartArea2.AxisX.LogarithmBase = 2D;
            chartArea2.AxisX.Maximum = 32D;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisX.Title = "Threads";
            chartArea2.AxisY.Title = "MB/s";
            chartArea2.Name = "ChartArea1";
            this.chartThreads.ChartAreas.Add(chartArea2);
            this.chartThreads.Location = new System.Drawing.Point(830, 32);
            this.chartThreads.Name = "chartThreads";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Series1";
            series2.Points.Add(dataPoint1);
            this.chartThreads.Series.Add(series2);
            this.chartThreads.Size = new System.Drawing.Size(322, 441);
            this.chartThreads.TabIndex = 13;
            this.chartThreads.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "4K随机写入速度-线程数";
            this.chartThreads.Titles.Add(title2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(476, 434);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 39);
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
            this.pictureBox2.Location = new System.Drawing.Point(830, 434);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chartFullSeq
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea3.AxisX.Title = "写入量(GB)";
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea3.AxisY.Title = "MB/s";
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 85.65887F;
            chartArea3.Position.Width = 98F;
            chartArea3.Position.Y = 11.34114F;
            this.chartFullSeq.ChartAreas.Add(chartArea3);
            this.chartFullSeq.Location = new System.Drawing.Point(28, 479);
            this.chartFullSeq.Name = "chartFullSeq";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.MarkerStep = 4;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartFullSeq.Series.Add(series3);
            this.chartFullSeq.Size = new System.Drawing.Size(1124, 250);
            this.chartFullSeq.TabIndex = 52;
            this.chartFullSeq.Text = "chart2";
            title3.Name = "Title1";
            title3.Text = "全盘连续写入";
            this.chartFullSeq.Titles.Add(title3);
            this.chartFullSeq.Click += new System.EventHandler(this.chartFullSeq_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(39, 785);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 20);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.Visible = false;
            // 
            // labelSysversion
            // 
            this.labelSysversion.AutoSize = true;
            this.labelSysversion.Location = new System.Drawing.Point(51, 32);
            this.labelSysversion.Name = "labelSysversion";
            this.labelSysversion.Size = new System.Drawing.Size(85, 20);
            this.labelSysversion.TabIndex = 1;
            this.labelSysversion.Text = "SysVersion";
            // 
            // labelcpu
            // 
            this.labelcpu.AutoSize = true;
            this.labelcpu.Location = new System.Drawing.Point(51, 64);
            this.labelcpu.Name = "labelcpu";
            this.labelcpu.Size = new System.Drawing.Size(38, 20);
            this.labelcpu.TabIndex = 2;
            this.labelcpu.Text = "CPU";
            // 
            // Form1
            //             //this.AutoScaleDimensions = new SizeF(1F, 1F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.AutoScaleDimensions = new System.Drawing.SizeF(92F, 92F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 733);
            this.Controls.Add(this.labelcpu);
            this.Controls.Add(this.comboBoxDisk);
            this.Controls.Add(this.labelSysversion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chartFullSeq);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFullSeq)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxDisk;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelSysversion;
        private System.Windows.Forms.Label labelcpu;
        private System.Windows.Forms.PictureBox pictureBoxL1;
        private System.Windows.Forms.PictureBox pictureBoxL2;
        private System.Windows.Forms.PictureBox pictureBoxL3;
        private System.Windows.Forms.PictureBox pictureBoxL4;
    }
}

