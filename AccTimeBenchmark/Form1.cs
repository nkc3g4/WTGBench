using iTuner;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AccTimeBenchmark
{
    public partial class Form1 : Form
    {
        private static UsbDisk UdObj;
        private static string diskRootPath;
        //private long dataLength = 1073737728L;
        private long dataLength = 536866816L;
        private int LoopTime4k = 30;
        //private long test4kCount = 8192 * 8192;
        private static uint FILE_FLAG_NO_BUFFERING = 536870912u;
        private static uint FILE_FLAG_WRITE_THROUGH = 2147483648u;
        private static uint file_flags = FILE_FLAG_NO_BUFFERING; //| FILE_FLAG_WRITE_THROUGH;
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess, FileShare dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        private readonly object threadCntLock = new object();
        private DateTime start4kTime;
        private void GenerateRandomArray(byte[] rnd_array)
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
            SWOnline swo = new SWOnline("https://bbs.luobotou.org/app/wtgbench.txt"); //
            Thread threadUpdate = new Thread(swo.Update);
            threadUpdate.Start();
            GetUdiskList.LoadUDList(comboBoxDisk);
            Text += Application.ProductVersion;
            Graphics graphics = CreateGraphics();
            float dpiX = graphics.DpiX;
            Width = (int)(900 * (dpiX / 96.0));
            Height = (int)(650 * (dpiX / 96.0));

            labelSysversion.Text = SysInfo.GetSysVersion(); ;
            labelcpu.Text = SysInfo.GetCPUModel();
            




        }
        private double WriteSeq(string path, object ctobj)
        {

            CancellationToken token = (CancellationToken)ctobj;

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
            SafeFileHandle safeFileHandle = CreateFile(path, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);

            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, 4096, false);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int seqSize = 67108864;
            byte[] seqBuffer = new byte[seqSize];
            GenerateRandomArray(seqBuffer);
            List<double> seqPoints = new List<double>();
            long testDuration = 10 * 1000;
            for (dataLength = 0L; dataLength < 10737418240; dataLength += seqSize)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
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
        private long ReadWrite(FileStream fileStream, long dataLength, byte[] buffer, int[] ioSizes, long runTime, float seqness, float writep, object ctobj)
        {
            CancellationToken token = (CancellationToken)ctobj;
            Random random = new Random();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            long num = 0L;
            long previousPosition = 0L;
            for (; sw.ElapsedMilliseconds <= runTime; num += 1L)
            {
                int length = ioSizes[random.Next(10)];
                if (token.IsCancellationRequested)
                {
                    break;
                }
                if (length == 0)
                    continue;
                long num2 = random.Next((int)(dataLength / length + 1));

                if (random.NextDouble() < seqness)
                {
                    fileStream.Position = previousPosition;
                }
                else
                {
                    fileStream.Position = num2 * length;
                }
                if (random.NextDouble() < writep)
                {
                    fileStream.Write(buffer, 0, length);
                }
                else
                {
                    fileStream.Read(buffer, 0, length);
                }
                previousPosition = num2 * length + length;

                fileStream.Flush();
            }


            return num;
        }
        private long RandomReadWrite(FileStream fileStream, byte[] buffer, int length, long runTime, bool write, object ctobj)
        {
            CancellationToken token = (CancellationToken)ctobj;
            Random random = new Random();
            GenerateRandomArray(buffer);
            while (DateTime.Now < start4kTime)
            {
                Thread.Sleep(10);
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long num = 0L;
            for (; sw.ElapsedMilliseconds <= runTime; num += 1L)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancel Req");
                    break;
                }
                long num2 = random.Next((int)(dataLength / length + 1));

                fileStream.Position = num2 * length;
                if (write)
                    fileStream.Write(buffer, 0, length);
                else
                    fileStream.Read(buffer, 0, length);
                fileStream.Flush();
            }


            return num;
        }

        private double Write4K_MultiThread(string path, int threadCount, List<FileStream> fsList, object ctobj)
        {
            long runTime = 30000;
            int length = 4096;
            byte[] buffer = new byte[length];
            GenerateRandomArray(buffer);

            //Thread.Sleep((int)runTime);
            start4kTime = DateTime.Now.AddSeconds(30);
            Task<long>[] taskArray = new Task<long>[threadCount];
            for (int i = 0; i < taskArray.Length; i++)
            {
                int index = i;
                taskArray[index] = Task<long>.Factory.StartNew(() =>
                {
                    Console.WriteLine(index);
                    return RandomReadWrite(fsList[index], buffer, length, runTime, true, ctobj);
                }, (CancellationToken)ctobj);

            }
            Task.WaitAll(taskArray);
            long total_IO = 0;
            for (int i = 0; i < taskArray.Length; i++)
            {
                Console.WriteLine(taskArray[i].Result);
                total_IO += taskArray[i].Result;

            }
            Console.WriteLine("Finish");

            return total_IO / 30.0 * 4096.0 / 1024 / 1024;
        }

        private double Write4k(string path, ref double adjustResult, object ctsobj)
        {
            CancellationToken token = (CancellationToken)ctsobj;

            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }));

            Random random = new Random();
            byte[] buffer = new byte[4096];
            GenerateRandomArray(buffer);

            SafeFileHandle safeFileHandle = CreateFile(path, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);

            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, 4096, false);
            fileStream.Position = dataLength;
            fileStream.Write(buffer, 0, 4096);
            Thread.Sleep(500);
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
                if (token.IsCancellationRequested)
                {

                    break;
                }
                long num2 = random.Next((int)(dataLength / 4096 + 1));

                long curTime = temp_timer.ElapsedMilliseconds;
                if (curTime - previousTime > 500)
                {
                    double curSpeed = ((num - prenum) * 4096.0 / 1024 / 1024) / ((curTime - previousTime) / 1000.0);
                    testPoints.Add(curSpeed);
                    prenum = num;
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = (int)(testPoints.Count / (double)LoopTime4k * 100.0);
                    }));
                    previousTime = temp_timer.ElapsedMilliseconds;
                }
                fileStream.Position = num2 * 4096;
                fileStream.Write(buffer, 0, 4096);
                fileStream.Flush();
            }

            fileStream.Close();
            temp_timer.Stop();
            progressBar1.Invoke(new Action(() => { progressBar1.Value = 100; }));

            double avg = testPoints.Average();

            chart1.Invoke(new Action(() =>
            {

                for (int i = 0; i < testPoints.Count(); i++)
                {

                    chart1.Series[0].Points.AddXY(i / 2.0, testPoints[i]);

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

            return avg;
        }



      
        private void SetTxt(TextBox tb, string text)
        {
            tb.Invoke(new Action(() => { tb.Text = text; }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (UdObj == null)
            {
                MessageBox.Show("请选择移动磁盘");
                return;
            }
            if (checkBoxScenario.Checked)
            {
                //Write4K_MultiThread(txtUDisk.Text + "test.bin", 16);
                //return;
            }
            CancellationTokenSource cts = new CancellationTokenSource();

            if (btnStart.Text == "开始")
            {

                tBench = new Thread(() =>
                {
                    try
                    {

                        if (checkBoxFast.Checked)
                            FastBenchmark(cts.Token);
                        if (checkBoxThread.Checked)
                        {
                            if (DiskOperation.GetHardDiskFreeSpace(diskRootPath) < 20 * 1024 * 1024)
                            {
                                MessageBox.Show("至少需要20GB可用空间进行测试！");
                                return;
                            }
                            if (checkBoxFast.Checked)
                                Thread.Sleep(10000);
                            MultiThreadBenchmark(cts.Token);

                        }
                        if (checkBoxFullSeq.Checked)
                        {
                            FullSeqBenchmark(cts.Token);
                            Thread.Sleep(10000);
                        }
                        if (checkBoxScenario.Checked)
                        {
                            if (DiskOperation.GetHardDiskFreeSpace(diskRootPath) < 20 * 1024 * 1024)
                            {
                                MessageBox.Show("至少需要20GB可用空间进行测试！");
                                return;
                            }
                            progressBar1.Invoke(new Action(() =>
                            {
                                progressBar1.Style = ProgressBarStyle.Marquee;
                            }));
                            List<Scenario> scenarios = new List<Scenario>();
                            scenarios.Add(CSVReader.Read(@".\Scenarios\normal_web.csv"));

                            long total_IO = ScenarioBenchmark(scenarios, cts.Token);
                            labelSceRes.Invoke(new Action(() => { labelSceRes.Text = (total_IO / 1000).ToString(); }));
                            progressBar1.Invoke(new Action(() =>
                            {
                                progressBar1.Style = ProgressBarStyle.Blocks;
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    btnStart.Invoke(new Action(() => { btnStart.Text = "开始"; }));
                });
                tBench.Start();
                btnStart.Text = "停止";
            }
            else
            {
                if (tBench != null)
                {
                    cts.Cancel();

                    tBench.Abort();
                    Environment.Exit(0);

                }
                btnStart.Text = "开始";
            }


        }
        private long ScenarioBenchmark(List<Scenario> scenarios, object ctobj)
        {
            string path = diskRootPath + "test.bin";
            int length = 4096;
            int runTime = 5000;
            List<FileStream> fsList = new List<FileStream>();
            byte[] buffer = new byte[length];
            GenerateRandomArray(buffer);
            dataLength = 536866816L;
            for (int i = 0; i < 32; i++)
            {
                File.Delete(path + i.ToString());
                SafeFileHandle safeFileHandle = CreateFile(path + i.ToString(), FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);

                FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, length, false);
                fileStream.Position = dataLength;
                fileStream.Write(buffer, 0, length);

                fsList.Add(fileStream);
            }
            buffer = new byte[16777216];
            GenerateRandomArray(buffer);
            Thread.Sleep(10000);
            long total_IO = 0;
            foreach (var sce in scenarios)
            {
                foreach (var testLine in sce.TestLines)
                {
                    Task<long>[] taskArray = new Task<long>[testLine.Threads];
                    for (int i = 0; i < taskArray.Length; i++)
                    {
                        int index = i;
                        taskArray[index] = Task<long>.Factory.StartNew(() =>
                        {
                            Console.WriteLine(index);
                            return ReadWrite(fsList[index], dataLength, buffer, testLine.IOSizes, runTime, testLine.SeqNess, testLine.WriteProportion, ctobj);
                        }, (CancellationToken)ctobj);

                    }
                    Task.WaitAll(taskArray);
                    for (int i = 0; i < taskArray.Length; i++)
                    {
                        total_IO += taskArray[i].Result;
                    }
                }
                Thread.Sleep(10000);
            }
            for (int i = 0; i < 32; i++)
            {
                fsList[i].Close();
                File.Delete(path + i.ToString());
            }
            return total_IO;


        }
        private void MultiThreadBenchmark(object ctobj)
        {
            chartThreads.Invoke(new Action(() =>
            {
                chartThreads.ChartAreas[0].AxisX.IsLogarithmic = false;
                chartThreads.Series[0].Points.Clear();

            }));
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }));
            string path = diskRootPath + "test.bin";
            int length = 4096;
            List<FileStream> fsList = new List<FileStream>();
            byte[] buffer = new byte[length];
            GenerateRandomArray(buffer);
            dataLength = 536866816L;
            for (int i = 0; i < 32; i++)
            {
                File.Delete(path + i.ToString());
                SafeFileHandle safeFileHandle = CreateFile(path + i.ToString(), FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.OpenOrCreate, file_flags, IntPtr.Zero);

                FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, length, false);
                fileStream.Position = dataLength;
                fileStream.Write(buffer, 0, length);

                fsList.Add(fileStream);
            }

            for (int i = 0; i <= 5; i++)
            {

                double result = Write4K_MultiThread(diskRootPath + "test.bin", 1 << i, fsList, ctobj);
                chartThreads.Invoke(new Action(() =>
                {
                    chartThreads.Series[0].Points.AddXY(1 << i, result);
                    chartThreads.ChartAreas[0].AxisX.IsLogarithmic = true;
                }));
                if (i < 5)
                    Thread.Sleep(20000);
            }
            for (int i = 0; i < 32; i++)
            {
                fsList[i].Close();
                File.Delete(path + i.ToString());
            }
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 100;
            }));

        }
        private void FullSeqBenchmark(object ctobj)
        {
            chartFullSeq.Invoke(new Action(() =>
            {
                //chartFullSeq.Series[0].Points.Clear();
            }));
            CancellationToken token = (CancellationToken)ctobj;

            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }));
            int ioLengthMB = 1;
            int steplengthMB = 256;

            Random random = new Random();
            byte[] buffer = new byte[1024 * 1024* ioLengthMB];
            GenerateRandomArray(buffer);
            string path = diskRootPath + "test.bin";
            if(File.Exists(path))
                File.Delete(path);
            long freeSpace = DiskOperation.GetHardDiskFreeSpace(diskRootPath);
            SafeFileHandle safeFileHandle = CreateFile(path, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.CreateNew, file_flags, IntPtr.Zero);

            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.ReadWrite, steplengthMB * 1024 * ioLengthMB, false);
            //fileStream.Position = 0;
            //fileStream.Write(buffer, 0, steplengthMB * 1024 * ioLengthMB);
            //fileStream.Flush();
            //progressBar1.Invoke(new Action(() =>
            //{
            //    progressBar1.Style = ProgressBarStyle.Blocks;
            //}));
            List<double> testPoints = new List<double>();
            Stopwatch speedTimer = new Stopwatch();
            //Console.WriteLine(Stopwatch.IsHighResolution);
            speedTimer.Start();
            Thread.Sleep(3000);
            //long prenum = 0L;
            long previousPos = 0L;
            // int loopTimes = 30;
            
            for (int num = 0; num < freeSpace / (steplengthMB * 1024 * 1024); num++)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                //Write steplengthMB
                
                double previousTime = speedTimer.Elapsed.TotalMilliseconds;
                for (int p = 0; p < steplengthMB / ioLengthMB; p++)
                {
                    fileStream.Position = previousPos + 1024 * 1024 * p;
                    fileStream.Write(buffer, 0, 1024 * 1024* ioLengthMB);
                    fileStream.Flush();
                }
                
                double curTime = speedTimer.Elapsed.TotalMilliseconds;
                //Console.WriteLine((curTime - previousTime) / 1000.0);
                double curSpeed = (float)steplengthMB / ((curTime - previousTime) / 1000.0);
                previousPos = previousPos + steplengthMB * 1024 * 1024;
                GenerateRandomArray(buffer);
                Console.WriteLine(curSpeed);
                if (num == 0)
                    continue;
                chartFullSeq.Invoke(new Action(() =>
                {
                    //chartFullSeq.Series[0].Points.AddY(curSpeed);
                    chartFullSeq.Series[0].Points.AddXY((num-1)/4.0, curSpeed);
                }));
                

            }

            fileStream.Close();
            File.Delete(path);
            speedTimer.Stop();
            progressBar1.Invoke(new Action(() => { progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 100; }));



        }
        private void FastBenchmark(object ctobj)
        {
            chart1.Invoke(new Action(() =>
            {
                chart1.Series[0].Points.Clear();
            }));
            double adj4k = 0;
            double timeseq = WriteSeq(diskRootPath + "test.bin", ctobj);
            //SetTxt(txtBenchSize, (dataLength / (1024 * 1024)).ToString());
            //dataLength

            SetTxt(txtSeqResult, timeseq.ToString("f4") + " MB/s");
            //txtSeqResult.Invoke(new Action(() => { txtSeqResult.Text = timeseq.ToString() + "MB/S"; }));
            double time4k = Write4k(diskRootPath + "test.bin", ref adj4k, ctobj);
            txt4kResult.Invoke(new Action(() => { txt4kResult.Text = time4k.ToString("f4") + " MB/s"; }));
            txtA4kResult.Invoke(new Action(() => { txtA4kResult.Text = adj4k.ToString("f4") + " MB/s"; }));
            File.Delete(diskRootPath + "test.bin");
            //double timeAcc = write_access(txtUDisk.Text + "test.bin");
            //txtAccResult.Invoke(new Action(() => { txtAccResult.Text = timeAcc.ToString() + " ms"; }));
            //btnStart.Invoke(new Action(() => { btnStart.Text = "开始"; }));

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-88-1.html");
        }

        private void labelLevel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("由高到低有Platinum、Gold、Silver、Bronze、Steel共5个等级。\nSilver及以上可用于制作Windows To Go，等级越高使用体验越好。");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-88-1.html");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-88-1.html");
        }

        private void chartFullSeq_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            UdObj = (UsbDisk)comboBoxDisk.SelectedItem;
            if(UdObj!=null)
                diskRootPath = UdObj.Volume.Substring(0, 1) + ":\\";
        }

        private void comboBoxDisk_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip1.SetToolTip(this.comboBoxDisk, comboBoxDisk.SelectedItem.ToString()); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
