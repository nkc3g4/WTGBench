using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace AccTimeBenchmark
{
    public partial class Form1 : Form
    {
        //private long dataLength = 1073737728L;
        private long dataLength = 536866816L;
        private int LoopTime4k = 30;
        //private long test4kCount = 8192 * 8192;
        private long testAccCount = 128;
        private static uint FILE_FLAG_NO_BUFFERING = 536870912u;
        private static uint FILE_FLAG_WRITE_THROUGH = 2147483648u;
        private static uint file_flags = FILE_FLAG_NO_BUFFERING | FILE_FLAG_WRITE_THROUGH;
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess, FileShare dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);
        private void generate_random_array(byte[] rnd_array)
        {
            Random random = new Random();
            for (int i = 0; i < rnd_array.Length; i++)
            {
                rnd_array[i] = (byte)random.Next(255);
            }
        }
        Thread tBench;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += Application.ProductVersion;
        }
        private double write_file_seq(string path)
        {
            //progressBar1.Invoke(new Action(() =>
            //{
            //    progressBar1.Style = ProgressBarStyle.Marquee;
            //}));

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
            SafeFileHandle safeFileHandle = CreateFile(path, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);
            if (safeFileHandle.IsInvalid)
            {
                throw new IOException("Could not open file stream.", new Win32Exception());
            }
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, 4096, false);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int seqSize = 67108864;
            byte[] seqBuffer = new byte[seqSize];
            generate_random_array(seqBuffer);
            List<double> seqPoints = new List<double>();
            long testDuration = 10 * 1000;
            for (dataLength = 0L; dataLength < 10737418240; dataLength += seqSize)
            {
                fileStream.Position = dataLength;

                long preTime = sw.ElapsedMilliseconds;
                fileStream.Write(seqBuffer, 0, seqSize);
                fileStream.Flush();
                long curTime = sw.ElapsedMilliseconds;
                seqPoints.Add((seqSize / (1024.0 * 1024)) / ((curTime - preTime) / 1000.0));
                progressBar1.Invoke(new Action(() =>
                {
                    int val = (int)((sw.ElapsedMilliseconds / (double)testDuration) * 100);
                    progressBar1.Value = val <= 100 ? val : 100;
                }));
                if (sw.ElapsedMilliseconds > testDuration)
                    break;
            }
            sw.Stop();
            fileStream.Close();
            return seqPoints.Average();
        }
        private double write_file_4k(string path, ref double adjustResult)
        {
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }));

            Random random = new Random();
            byte[] buffer = new byte[4096];
            generate_random_array(buffer);

            SafeFileHandle safeFileHandle = CreateFile(path, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);
            if (safeFileHandle.IsInvalid)
            {
                throw new IOException("Could not open file stream.", new Win32Exception());
            }
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, 4096, false);
            //MessageBox.Show(dataLength.ToString());
            fileStream.Position = dataLength;
            fileStream.Write(buffer, 0, 4096);
            Thread.Sleep(500);

            //for (long num = 0L; num < 2561L; num += 1L)
            //{
            //    int num2 = random.Next(2561);
            //    fileStream.Position = num2 * 4096;
            //    fileStream.Write(buffer, 0, 4096);
            //}
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }));
            List<double> testPoints = new List<double>();
            Stopwatch temp_timer = new Stopwatch();
            temp_timer.Start();
            long previousTime = 0L;
            long prenum = 0L;
           // int loopTimes = 30;
            for (long num = 0L; testPoints.Count < LoopTime4k; num += 1L)
            {
                long num2 = random.Next((int)(dataLength / 4096 + 1));

                long curTime = temp_timer.ElapsedMilliseconds;
                if (curTime - previousTime > 500)
                {
                    testPoints.Add(((num - prenum) * 4096.0 / 1024 / 1024) / ((curTime - previousTime) / 1000.0));
                    prenum = num;
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = (int)(testPoints.Count / (double)LoopTime4k * 100.0);
                    }));
                    previousTime = temp_timer.ElapsedMilliseconds;
                }
                //if (num % 512 == 1)
                //{
                //    previousTime = temp_timer.ElapsedMilliseconds;
                //}
                //MessageBox.Show((num2 * 4096).ToString());
                fileStream.Position = num2 * 4096;
                fileStream.Write(buffer, 0, 4096);
                fileStream.Flush();

                //if (num != 0 && num % 512 == 0)
                //{
                //    //long cur = temp_timer.ElapsedMilliseconds;

                //    //testPoints.Add((511.0 * 4096 / 1024 / 1024) / ((cur - previousTime) / 1000.0));

                //    //previousTime = temp_timer.ElapsedMilliseconds;

                //    progressBar1.Invoke(new Action(() => {
                //        progressBar1.Value = (int)(testPoints.Count / 20 * 100.0);
                //        //progressBar1.Value = (int)(num / (double)test4kCount * 100.0);
                //    }));


                //}
                //sw.Stop();
                //Console.WriteLine(sw.ElapsedMilliseconds);
            }

            fileStream.Close();
            temp_timer.Stop();
            progressBar1.Invoke(new Action(() => { progressBar1.Value = 100; }));



            //hiPerfTimer.Stop();
            //result = hiPerfTimer.Duration;
            //adjustResult
            double avg = testPoints.Average();
            chart1.Invoke(new Action(() => {
                foreach (var item in testPoints)
                {
                    chart1.Series[0].Points.AddY(item);
                }
            }));

            testPoints.AddRange(testPoints.GetRange(LoopTime4k / 2, LoopTime4k / 2));
            //testPoints.RemoveAll((m) => { return m > avg * 1.5; });

            int cnt = testPoints.Count;



            for (int i = 0; i < cnt; i++)
            {
                if (testPoints[i] < avg * 0.5)
                {
                    testPoints.Add(testPoints[i]);
                }
            }
            adjustResult = testPoints.Average();
           
            //chart1.Series[0].Points.AddY
            //textBox1.Invoke(new Action(() =>
            //{
            //    foreach (var item in testPoints)
            //    {

            //        textBox1.Text += item.ToString() + Environment.NewLine;

            //    }
            //}));
            return avg;
            //return (test4kCount * 4096 / 1024 / 1024) / (temp_timer.ElapsedMilliseconds / 1000.0);
        }

        private double write_access(string path)
        {
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }));

            //FileInfo fileInfo = new FileInfo(path);
            //fileInfo.Delete();
            Random random = new Random();
            //HiPerfTimer hiPerfTimer = new HiPerfTimer();
            byte[] buffer = new byte[4096];
            generate_random_array(buffer);
            SafeFileHandle safeFileHandle = CreateFile(path, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);
            if (safeFileHandle.IsInvalid)
            {
                throw new IOException("Could not open file stream.", new Win32Exception());
            }
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, 4096, false);
            fileStream.Position = dataLength;
            fileStream.Write(buffer, 0, 4096);

            for (long num = 0L; num < 64L; num += 1L)
            {
                //this.w_a = num;
                //generate_random_array(buffer); 
                int num2 = random.Next(262144);
                fileStream.Position = num2 * 4096;
                fileStream.Write(buffer, 0, 512);
                fileStream.Flush();

                //swTmp.Stop();
            }

            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }));

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Stopwatch swTmp = new Stopwatch();
            //hiPerfTimer.Start();
            for (long num = 0L; num < testAccCount; num += 1L)
            {
                if (num % 4 == 0)
                {
                    progressBar1.Invoke(new Action(() => { progressBar1.Value = (int)(num / (double)testAccCount * 100.0); }));
                }
                //this.w_a = num;
                //generate_random_array(buffer);
                //swTmp.Reset();
                //swTmp.Start();
                int num2 = random.Next(262144);

                fileStream.Position = num2 * 4096;


                fileStream.Write(buffer, 0, 512);
                fileStream.Flush();

                //swTmp.Stop();
                //Console.WriteLine(swTmp.ElapsedMilliseconds);

                //swTmp.Stop();

            }

            fileStream.Close();
            fileStream.Dispose();
            sw.Stop();
            progressBar1.Invoke(new Action(() => { progressBar1.Value = 100; }));
            File.Delete(path);
            return sw.ElapsedMilliseconds / (double)testAccCount;
            //hiPerfTimer.Stop();
            //return hiPerfTimer.Duration / 26214.0;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath.Length != 3)
            {
                if (fbd.SelectedPath.Length != 0)
                {
                    //MsgManager.getResString("Msg_UDRoot")
                    //请选择优盘根目录
                    MessageBox.Show("请选择移动磁盘根目录");
                }
                return;

            }
            txtUDisk.Text = fbd.SelectedPath;
        }
        private void SetTxt(TextBox tb, string text)
        {
            tb.Invoke(new Action(() => { tb.Text = text; }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUDisk.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请选择移动磁盘");
                return;
            }
            if (btnStart.Text == "开始")
            {
                tBench = new Thread(() =>
                {
                    try
                    {
                        double adj4k = 0;
                        double timeseq = write_file_seq(txtUDisk.Text + "test.bin");
                        SetTxt(txtBenchSize, (dataLength / (1024 * 1024)).ToString());
                        //dataLength
                        
                        SetTxt(txtSeqResult, timeseq.ToString() + "MB/S");
                        //txtSeqResult.Invoke(new Action(() => { txtSeqResult.Text = timeseq.ToString() + "MB/S"; }));
                        double time4k = write_file_4k(txtUDisk.Text + "test.bin", ref adj4k);
                        txt4kResult.Invoke(new Action(() => { txt4kResult.Text = time4k.ToString() + " MB/S"; }));
                        txtA4kResult.Invoke(new Action(() => { txtA4kResult.Text = adj4k.ToString() + "MB/S"; }));
                        File.Delete(txtUDisk.Text + "test.bin");
                        //double timeAcc = write_access(txtUDisk.Text + "test.bin");
                        //txtAccResult.Invoke(new Action(() => { txtAccResult.Text = timeAcc.ToString() + " ms"; }));
                        btnStart.Invoke(new Action(() => { btnStart.Text = "开始"; }));

                        double score = adj4k + Math.Log(1 + (timeseq / 1000));
                        //MessageBox.Show(bmr.Write4K.ToString());
                        int lv = 0;
                        if (score > 30)
                        {
                            lv = 5;
                        }
                        else if (score > 10)
                        {
                            lv = 4;
                        }
                        else if (score > 0.8)
                        {
                            lv = 3;
                        }
                        else if (score > 0.3)
                        {
                            lv = 2;
                        }
                        else
                        {
                            lv = 1;
                        }

                        string ln = "Error";
                        Color lc = Color.Yellow;

                        if (lv == 1)
                        {
                            ln = "Steel";
                            lc = Color.SteelBlue;
                        }
                        else if (lv == 2)
                        {
                            ln = "Bronze";
                            lc = Color.Crimson;
                        }
                        else if (lv == 3)
                        {
                            ln = "Silver";
                            lc = Color.Silver;
                        }
                        else if (lv == 4)
                        {
                            ln = "Gold";
                            lc = Color.Gold;
                        }
                        else if (lv == 5)
                        {
                            ln = "Platinum";
                            lc = Color.White;
                        }
                        labelLevel.Invoke(new Action(() =>
                        {
                            labelLevel.Text = ln;
                            labelLevel.ForeColor = lc;
                        }));


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    //MessageBox.Show(time4k.ToString());
                    //File.Delete(txtUDisk.Text + "test.bin");
                });
                tBench.Start();
                btnStart.Text = "停止";
            }
            else
            {
                if (tBench != null)
                {
                    tBench.Abort();
                }
                btnStart.Text = "开始";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-88-1.html");
        }
    }
}
