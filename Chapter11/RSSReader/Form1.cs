using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSReader
{
    public partial class Form1 : Form
    {
        List<String> titleList = new List<string>();
        List<String> linkList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient())
            {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var Rssdoc = XDocument.Load(stream);
                var RssItem = Rssdoc.Root.Descendants("item");

                foreach (var RssDate in RssItem.Select(x => x.Element("title")))
                {
                    lbRssTitle.Items.Add(RssDate);
                    string newstring = new string
                    {

                    };
                }
            }
           
        }

        private void lbRssTitle_Click(object sender, EventArgs e)
        {
            var index = lbRssTitle.SelectedIndex;
            var stream = new WebClient().OpenRead(cbRssUrl.Text);

            var Rssdoc = XDocument.Load(stream);
            var RssItem = Rssdoc.Root.Descendants("item").Select(x => x.Element("link"));
            
            wbBrowser.DocumentText = index.ToString();
        }
    }
}
