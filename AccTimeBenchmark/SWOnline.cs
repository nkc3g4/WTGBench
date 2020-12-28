using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccTimeBenchmark
{

    public class SWOnline
    {

        public SWOnline()
        {


        }
        public SWOnline(string releaseUrl)
        {
            this.ReleaseUrl = releaseUrl;
        }
        private string releaseUrl;

        public string ReleaseUrl
        {
            get { return releaseUrl; }
            set { releaseUrl = value; }
        }


        public void Update()
        {
            string autoup = IniFile.ReadVal("Main", "AutoUpdate", Application.StartupPath + "\\settings.ini");
            if (autoup == "0") { return; }
            string pageHtml;
            try
            {
                WebClient MyWebClient = new WebClient();
                //MyWebClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;
                byte[] pageData = MyWebClient.DownloadData(releaseUrl); //从指定网站下载数据"https://bbs.luobotou.org/app/wintogo.txt"

                pageHtml = Encoding.UTF8.GetString(pageData);
                int index = pageHtml.IndexOf("~");
                Version newVer = new Version(pageHtml.Substring(index + 1, 7));
                Version currentVer = new Version(Application.ProductVersion);

                if (newVer > currentVer)
                {
                    Update frmf = new Update(newVer.ToString());
                    frmf.ShowDialog();
                }

            }
            catch (WebException webEx)
            {
                //Log.WriteLog("Err_UpdateErr", webEx.ToString());
            }
        }




    }


}
