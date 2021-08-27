using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccTimeBenchmark
{
    public static class FileOperation
    {
        public static void DeleteFolder(string dir)
        {
            if (Directory.Exists(dir))   
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;

                        File.Delete(d);     
                    }
                    else
                        DeleteFolder(d);  
                }
                Directory.Delete(dir, true);                      
            }
        }
        public static string GetFileVersion(string path)
        {
            try
            {
                // Get the file version for the notepad.   
                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(path);
                return myFileVersionInfo.FileVersion;
                // Print the file name and version number.   
                //textBox1.Text = "File: " + myFileVersionInfo.FileDescription + '\n' +
                //"Version number: " + myFileVersionInfo.FileVersion;
            }
            catch (Exception ex)
            {
                return "System Version Unknown";
            }
        }


        public static void DeleteFile(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

    }
}
