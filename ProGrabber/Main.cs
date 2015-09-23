using HtmlAgilityPack;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            GrabType(cmProxyType.Text.ToLower());
        }

        public static void GrabType(String pType)
        {
            switch (pType)
            {
                case "ssl proxies":
                    // http://sslproxies24.blogspot.com/
                    Grab("http://sslproxies24.blogspot.com/");
                    break;
                case "google proxies":
                    // http://googleproxies24.blogspot.com/

                    break;
                case "l1 / l2 / l3 http proxies mixed":
                    // http://proxyserverlist-24.blogspot.com/

                    break;
                    // default:
                    // Default would be ssl proxies, i suppose!
            }
        }

        public static void Grab(string pURL)
        {
            var Webget = new HtmlWeb();
            var doc = Webget.Load(pURL);

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//h3[@class='post-title entry-title']//a"))
            {
                
            }
        }

        public static void GrabProxies(string innerProxyURL)
        {

        }
    }
}
