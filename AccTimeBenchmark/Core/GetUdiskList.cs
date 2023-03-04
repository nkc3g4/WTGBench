using iTuner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccTimeBenchmark
{
    public static class GetUdiskList
    {
        private static Thread tListUDisks;
        public static UsbDiskCollection diskCollection = new UsbDiskCollection();

        #region Udisk
        public delegate void OutDelegate(bool isend, object dtSource, ComboBox combobox);
        public static void OutText(bool isend, object dtSource, ComboBox comboBoxUd)
        {
            if (comboBoxUd.InvokeRequired)
            {
                OutDelegate outdelegate = new OutDelegate(OutText);
                comboBoxUd.BeginInvoke(outdelegate, new object[] { isend, dtSource, comboBoxUd });
                return;
            }
            comboBoxUd.DataSource = null;
            comboBoxUd.DataSource = dtSource;

            if (comboBoxUd.Items.Count != 0)
            {
                comboBoxUd.SelectedIndex = 0;
            }
            if (isend)
            {
                comboBoxUd.SelectedIndex = comboBoxUd.Items.Count - 1;
            }
        }

        private static UsbDiskCollection GetUsbDiskCollection()
        {
            UsbManager manager = new UsbManager();

            UsbDiskCollection usbDisks = new UsbDiskCollection();
            try
            {
                
                foreach (UsbDisk disk in manager.GetAvailableVolumns())
                {
                    usbDisks.Add(disk);
                }
            }
            catch (Exception ex) { 
            }
            return usbDisks;
        }
        public static void GetUdiskInfo()
        {

            UsbManager manager = new UsbManager();
            try
            {
                var newDiskCollection = GetUsbDiskCollection();
                if (!diskCollection.SequenceEqual(newDiskCollection))
                {
                    diskCollection = newDiskCollection;
                    OutText(false, diskCollection, cbb);
                }
            }
            catch (Exception ex) {  }
            finally
            {
                manager.Dispose();
            }

        }

        public static void LoadUDList(ComboBox comboBoxUd)
        {
            cbb = comboBoxUd;
            GetUdiskInfo();
            //Udlist = new Udlist();
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Interval = 2000;
            timer1.Start();
        }
        static ComboBox cbb = null;
        private static void timer1_Tick(object sender, EventArgs e)
        {
            if (cbb.SelectedIndex == 0)
            {
                tListUDisks = new Thread(GetUdiskInfo);
                tListUDisks.Start();
            }
        }
        #endregion
    }

}
