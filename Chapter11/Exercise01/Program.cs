using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

            // これは確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var ballSports = xdoc.Root.Elements()
                                .Select(x => new 
                                { 
                                    Name = (string)x.Element("name"),
                                    TeamMembers = (string)x.Element("teammembers"),
                                });

            foreach (var ballSport in ballSports)
            {
                Console.WriteLine("[競技名]{0} | [プレー人数]{1}人", ballSport.Name, ballSport.TeamMembers);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var ballSports = xdoc.Root.Elements()
                                    .OrderBy(x =>(string)x.Element("firstplayed"))
                                    .Select(x => new 
                                    {
                                        Name = (string)x.Element("name").Attribute("kanji"),
                                        FirstPlayed = (string)x.Element("firstplayed"),
                                    });
            foreach (var ballSport in ballSports)
            {
                Console.WriteLine("{0} ({1}年)",ballSport.Name,ballSport.FirstPlayed);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var ballSports = xdoc.Root.Elements()
                                        .Select(x => new
                                        {
                                            Name = x.Element("name").Value,
                                            Teammembers = x.Element("teammembers").Value,
                                        })
                                        .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();
            Console.WriteLine("{0}　<{1}人>",ballSports.Name,ballSports.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile)
        {
            var element = new XElement("ballsport",
                                new XElement("name", "サッカーボール", new XAttribute("kanji", "蹴球")),
                                new XElement("teammembers", "9"),
                                new XElement("firstplayed", "1863")
                                );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);

            xdoc.Save(newfile);
        }
    }
}
