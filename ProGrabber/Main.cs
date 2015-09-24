using HtmlAgilityPack;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ProGrabber
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGrabThem_Click(object sender, EventArgs e)
        {
            // Sock Proxies
            // SSL Proxies
            // Google Proxies
            // Server Proxies

            if(cmProxyType.Text != null || cmProxyType.Text != "")
            {
                GrabType(cmProxyType.Text.ToLower());
            }
            else
            {
                MessageBox.Show("Grab what?! Store to?!?");
            }
        }

        public static void GrabType(String pType)
        {
            switch (pType)
            {
                case "sock proxies":
                    Grab("http://socksproxylist24.blogspot.com/", pType);
                    break;
                case "ssl proxies":
                    Grab("http://sslproxies24.blogspot.com/", pType);
                    break;
                case "google proxies":
                    Grab("http://googleproxies24.blogspot.com/", pType);
                    break;
                case "server proxies":
                    Grab("http://proxyserverlist-24.blogspot.com/", pType);
                    break;
            }
        }

        public static void Grab(string pURL, string pType)
        {
            var Webget = new HtmlWeb();
            var doc = Webget.Load(pURL);

            foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//h3[@class='post-title entry-title']//a"))
            {
                string link = N.Attributes["href"].Value;

                if(link != null &&
                    link != "" &&
                    !string.IsNullOrEmpty(link))
                {
                    new Thread(() => GrabProxies(link, pType)).Start();
                }
                else
                {
                    MessageBox.Show("Failed to retrieve valid node!");
                }
            }
        }

        public static void GrabProxies(string innerProxyURL, string pType)
        {
            try
            {
                var Webget = new HtmlWeb();
                var doc = Webget.Load(innerProxyURL);

                switch (pType)
                {
                    case "sock proxies":
                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//textarea[@onclick='this.focus();this.select()']"))
                        {
                            File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), N.InnerText.Split(new string[] { "\n" }, StringSplitOptions.None));
                        }
                        break;
                    case "ssl proxies":
                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//pre[@class='alt2']"))
                        {
                            File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), N.InnerText.Split(new string[] { "\n" }, StringSplitOptions.None));
                        }
                        break;
                    case "google proxies":

                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//span[@style='color: #ffffff;']"))
                        {
                            File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), N.InnerText.Split(new string[] { "\n" }, StringSplitOptions.None));
                        }

                        break;
                    case "server proxies":

                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//span[@style='color: #ffffff;']"))
                        {
                            File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), N.InnerText.Split(new string[] { "\n" }, StringSplitOptions.None));
                        }

                        break;
                }
            }
            catch {
                MessageBox.Show("Failed to obtain & save the requested proxies!");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Proxies"))
            {
                Directory.CreateDirectory("Proxies");
            }
            else { }
        }

        private void btnBrowseSD_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtStoreDirectory.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
