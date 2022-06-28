using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;

namespace XmlSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var wc = new WebClient())
            {
                var stream = new WebClient().OpenRead("https://news.yahoo.co.jp/rss/media/abn/all.xml");

                var xdoc = XDocument.Load(stream);
                var xNews = xdoc.Root.Descendants("item").Select(x => x.Element("title"));
                //Elements().OrderBy(x => ((DateTime)x.Element("birth")).Year >= 1900);

                foreach (var date in xNews)
                {
                    /*var xname = xnovelist.Element("name");

                    var birth = (DateTime)xnovelist.Element("birth");
                    Console.WriteLine("{0} {1}",xname.Value,birth.ToShortDateString());*/
                    Console.WriteLine(date);
                }
            }            
        }
    }
}
