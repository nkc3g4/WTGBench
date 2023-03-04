using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AccTimeBenchmark
{
    public static class SysInfo
    {
        public static string GetCPUModel()
        {
            
            string CPUName = "";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_Processor");//Win32_Processor 
                foreach (ManagementObject mo in searcher.Get())
                {
                    CPUName = mo["Name"].ToString();
                }
                searcher.Dispose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return CPUName;

        }
        public static string GetSysVersion()
        {
            string sysVersion = "";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from win32_OperatingSystem");
                foreach (ManagementObject os in searcher.Get())
                {
                    sysVersion = os["Caption"].ToString()+" "+os["Version"].ToString();
                }
                searcher.Dispose();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return sysVersion;
        }
    }
}
