using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01
{
    [XmlRoot("novel")]
    public class Employee
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        public DateTime HireDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));


        }

        private static void Exercise1_1(string outfile)
        {
            var emp = new Employee
            {
                Id = 123,
                Name = "井出　幸太郎",
                HireDate = new DateTime(2001, 5, 10)
            };

            using (var writer = XmlWriter.Create("employee.xml"))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            using (var reader = XmlReader.Create("employee.xml"))
            {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);

            }
        }

        private static void Exercise1_2(string v)
        {
            var emp = new Employee[]
            {
                new Employee
                {
                    Id = 123,
                    Name = "井出　幸太郎",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee
                {
                    Id = 456,
                    Name = "中澤　康介",
                    HireDate = new DateTime(2002, 1, 3),
                },
                
            };

            using (var writer = XmlWriter.Create("employees.xml"))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
        }

        private static void Exercise1_3(string v)
        {
            using (var reader = XmlReader.Create("employees.xml"))
            {
                var serializer = new XmlSerializer(typeof(Employee[]));
                var employee = serializer.Deserialize(reader) as Employee[];
                foreach (var employees in employee)
                {
                    Console.WriteLine(employees);
                }
            }
        }

        private static void Exercise1_4(string v)
        {
            var emp = new Employee[]
            {
                new Employee
                {
                    Id = 123,
                    Name = "井出　幸太郎",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee
                {
                    Id = 456,
                    Name = "中澤　康介",
                    HireDate = new DateTime(2002, 1, 3),
                },

            };

            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };

            using (var writer = XmlWriter.Create("employees.json", settings))
            {
                var serializer = new DataContractJsonSerializer(emp.GetType()); //P185
                serializer.WriteObject(writer, emp);
            }

            using (var reader = XmlReader.Create("employees.json"))
            {
                var serializer = new DataContractJsonSerializer(typeof(Employee[]));
                var employee = serializer.ReadObject(reader) as Employee[];
                //Console.WriteLine(novel);
                foreach (var employees in employee)
                {
                    Console.WriteLine(employees);
                }
            }
        }
    }
}
