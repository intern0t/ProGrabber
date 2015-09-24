using HtmlAgilityPack;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ProGrabber
{
    public partial class s : MetroForm
    {
        private static String storePath = string.Empty;

        public s()
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

                string Proxies = string.Empty;

                switch (pType)
                {
                    case "sock proxies":
                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//textarea[@onclick='this.focus();this.select()']"))
                        {
                            Proxies = N.InnerText;
                        }
                        break;
                    case "ssl proxies":
                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//pre[@class='alt2']"))
                        {
                            Proxies = N.InnerText;
                        }
                        break;
                    case "google proxies":

                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//span[@style='color: #ffffff;']"))
                        {
                            Proxies = N.InnerText;
                        }

                        break;
                    case "server proxies":

                        foreach (HtmlNode N in doc.DocumentNode.SelectNodes("//span[@style='color: #ffffff;']"))
                        {
                            Proxies = N.InnerText;
                        }

                        break;
                }

                if (!string.IsNullOrEmpty(storePath))
                {
                    // It's not empty - user seems to have provided where to store the proxies!
                    File.WriteAllLines(@storePath + "//" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), Proxies.Split(new string[] { "\n" }, StringSplitOptions.None));
                }
                else
                {
                    // No input from the user! Use the APP.STARTUP path.
                    File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), Proxies.Split(new string[] { "\n" }, StringSplitOptions.None));
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
                    txtStoreDirectory.Text = @fbd.SelectedPath;
                    storePath = @fbd.SelectedPath;
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtStoreDirectory.Clear();
            cmProxyType.SelectedIndex = -1;
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storePath))
            {
                Process.Start(@storePath);
            }
            else
            {
                Process.Start(Application.StartupPath);
            }
        }

        private void lnkCopyright_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.crackingking.com/");
            Process.Start("https://www.crackingking.com/member.php?action=profile&uid=2");
        }
    }
}
