using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
            ReleaseUrl = releaseUrl;
        }

        public string ReleaseUrl { get; set; }

        public string[] TopicLink { get; set; }

        public string[] TopicName { get; set; }

        public LinkLabel Linklabel { get; set; }
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
                byte[] pageData = MyWebClient.DownloadData(ReleaseUrl); //从指定网站下载数据"https://bbs.luobotou.org/app/wintogo.txt"

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
                Console.WriteLine(webEx);
                //Log.WriteLog("Err_UpdateErr", webEx.ToString());
            }
        }
        public void Showad()
        {
            string pageHtml;
            try
            {
                WebClient MyWebClient = new WebClient();

                MyWebClient.Credentials = CredentialCache.DefaultCredentials;

                byte[] pageData = MyWebClient.DownloadData(ReleaseUrl); //从指定网站下载数据
                //MyWebClient.DownloadString()
                pageHtml = Encoding.UTF8.GetString(pageData);
                int index = pageHtml.IndexOf("announcement=");
                int indexbbs = pageHtml.IndexOf("bbs=");
                if (pageHtml.Substring(index + 13, 1) != "0")
                {
                    if (pageHtml.Substring(indexbbs + 4, 1) == "1")
                    {
                        MyWebClient.Credentials = CredentialCache.DefaultCredentials;
                        byte[] pageData1 = MyWebClient.DownloadData("https://bbs.luobotou.org/portal.php");
                        pageHtml = Encoding.UTF8.GetString(pageData1);

                        #region 正则表达式实现

                        Match matchArticles = Regex.Match(pageHtml, @"<ul><li><a href=[\W\w]+?</li></ul>");
                        MatchCollection matches = Regex.Matches(matchArticles.Groups[0].Value, @"<li><a href=""(.+?)"".+?>(.+?)</a></li>");

                        for (int i = 0; i < matches.Count; i++)
                        {
                            TopicLink[i] = matches[i].Groups[1].Value;
                            TopicName[i] = matches[i].Groups[2].Value;
                            //Console.WriteLine(TopicName[i]);

                        }
                        #endregion

                    }
                    pageHtml = MyWebClient.DownloadString("https://bbs.luobotou.org/app/announcement.txt");
                    Match match = Regex.Match(pageHtml, Application.ProductName + "=(.+)~(.+)结束");
                    string adlink = match.Groups[2].Value;
                    string adtitle = match.Groups[1].Value;
                    Linklabel.Invoke(new Action(() =>
                    {
                        Linklabel.Text = adtitle;
                        Linklabel.Visible = true;
                    }));
                    Linklabel.Tag = adlink;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //Log.WriteLog("Err_ShowAdError", ex.ToString());
            }
        }




    }


}
