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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUDisk = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBenchSize = new System.Windows.Forms.TextBox();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeqResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA4kResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4kResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUDisk
            // 
            this.txtUDisk.Location = new System.Drawing.Point(53, 70);
            this.txtUDisk.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtUDisk.Name = "txtUDisk";
            this.txtUDisk.ReadOnly = true;
            this.txtUDisk.Size = new System.Drawing.Size(479, 43);
            this.txtUDisk.TabIndex = 0;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(555, 67);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(200, 67);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "选择";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "测试数据量";
            // 
            // txtBenchSize
            // 
            this.txtBenchSize.Location = new System.Drawing.Point(263, 63);
            this.txtBenchSize.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtBenchSize.Name = "txtBenchSize";
            this.txtBenchSize.ReadOnly = true;
            this.txtBenchSize.Size = new System.Drawing.Size(130, 43);
            this.txtBenchSize.TabIndex = 4;
            // 
            // txtLoop
            // 
            this.txtLoop.Location = new System.Drawing.Point(609, 63);
            this.txtLoop.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.ReadOnly = true;
            this.txtLoop.Size = new System.Drawing.Size(130, 43);
            this.txtLoop.TabIndex = 6;
            this.txtLoop.Text = "10s/15s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "测试时间";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.txtUDisk);
            this.groupBox1.Location = new System.Drawing.Point(53, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(808, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择移动磁盘";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(53, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox2.Size = new System.Drawing.Size(808, 669);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "性能测试";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 54);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 89);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelLevel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSeqResult);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtLoop);
            this.groupBox3.Controls.Add(this.txtA4kResult);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBenchSize);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt4kResult);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(0, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Size = new System.Drawing.Size(808, 511);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测试结果";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Black;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLevel.Location = new System.Drawing.Point(263, 357);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(0, 61);
            this.labelLevel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "等级";
            // 
            // txtSeqResult
            // 
            this.txtSeqResult.Location = new System.Drawing.Point(263, 122);
            this.txtSeqResult.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtSeqResult.Name = "txtSeqResult";
            this.txtSeqResult.ReadOnly = true;
            this.txtSeqResult.Size = new System.Drawing.Size(476, 43);
            this.txtSeqResult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seq.";
            // 
            // txtA4kResult
            // 
            this.txtA4kResult.Location = new System.Drawing.Point(263, 257);
            this.txtA4kResult.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtA4kResult.Name = "txtA4kResult";
            this.txtA4kResult.ReadOnly = true;
            this.txtA4kResult.Size = new System.Drawing.Size(476, 43);
            this.txtA4kResult.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adjust 4K";
            // 
            // txt4kResult
            // 
            this.txt4kResult.Location = new System.Drawing.Point(263, 181);
            this.txt4kResult.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt4kResult.Name = "txt4kResult";
            this.txt4kResult.ReadOnly = true;
            this.txt4kResult.Size = new System.Drawing.Size(476, 43);
            this.txt4kResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "4K";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(613, 54);
            this.btnStart.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 89);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(682, 914);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 36);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "萝卜头IT论坛";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "时间(s)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(891, 61);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(603, 827);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "4K";
            this.chart1.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 971);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows To Go磁盘测速";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUDisk;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBenchSize;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt4kResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtSeqResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA4kResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

