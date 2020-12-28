using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccTimeBenchmark
{
    class DiskOperation
    {
        public static long GetHardDiskFreeSpace(string str_HardDiskName)
        {
            long totalSize = new long();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    totalSize = drive.TotalFreeSpace;

                }
            }
            return totalSize;
        }
    }

}

