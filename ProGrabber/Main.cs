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
                MessageBox.Show("Grab what?!");
            }
        }

        public static void GrabType(String pType)
        {
            switch (pType)
            {
                case "sock proxies":
                    Grab("http://socksproxylist24.blogspot.com/");
                    break;
                case "ssl proxies":
                    Grab("http://sslproxies24.blogspot.com/");
                    break;
                case "google proxies":
                    Grab("http://googleproxies24.blogspot.com/");
                    break;
                case "server proxies":
                    Grab("http://proxyserverlist-24.blogspot.com/");
                    break;
            }
        }

        public static void Grab(string pURL)
        {
            var Webget = new HtmlWeb();
            var doc = Webget.Load(pURL);

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//h3[@class='post-title entry-title']//a[@href]"))
            {
                string link = (node.Attributes["href"].Value);

                if (!string.IsNullOrEmpty(link))
                {
                    new Thread(() => GrabProxies(link)).Start();
                }
                else { }
            }
        }

        public static void GrabProxies(string innerProxyURL)
        {
            try
            {
                var Webget = new HtmlWeb();
                var doc = Webget.Load(innerProxyURL);

                foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//span[@style='color: #ffffff;']"))
                {
                    File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), N.InnerText.Split(new string[] { "\n" }, StringSplitOptions.None));
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
        }
    }
}
