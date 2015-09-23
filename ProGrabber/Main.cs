using HtmlAgilityPack;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
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
            // SSL Proxies
            // Google Proxies
            // L1 / L2 / L3 HTTP Proxies Mixed

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
            var Webget = new HtmlWeb();
            var doc = Webget.Load(innerProxyURL);

            foreach(HtmlNode N in doc.DocumentNode.SelectNodes("//pre[@class='alt2']"))
            {
                File.WriteAllLines(@Application.StartupPath + "/Proxies/" + innerProxyURL.Split('/')[5].Replace("html", ".txt"), N.InnerText.Split(new string[] { "\n" }, StringSplitOptions.None));
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
