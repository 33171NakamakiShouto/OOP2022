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
        public Form1()
        {
            InitializeComponent();
        }

        IEnumerable<XElement> RssItem ;

        private void btRssGet_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient())
            {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var Rssdoc = XDocument.Load(stream);
                RssItem = Rssdoc.Root.Descendants("item");

                foreach (var RssDate in RssItem)
                {
                    lbRssTitle.Items.Add((string)RssDate.Element("title"));
                }
            }

            setcbRssUrl(cbRssUrl.Text);
        }

        private void setcbRssUrl(string url)
        {
            if (cbRssUrl.Items.IndexOf(cbRssUrl.Text) == -1)
            {
                cbRssUrl.Items.Add(cbRssUrl.Text);
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e)
        {
            if (lbRssTitle.SelectedItem == null) return;
            var index = lbRssTitle.SelectedIndex;
            wvBrouser.Navigate((string)RssItem.ElementAt(index).Element("link"));
            
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            wvBrouser.GoBack();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            wvBrouser.GoForward();
        }
    }
}
