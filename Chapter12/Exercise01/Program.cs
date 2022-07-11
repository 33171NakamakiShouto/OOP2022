using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
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

        public override string ToString()
        {
            return string.Format("[id = {0}, name = {1}, hiredate = {2}]",
                                  Id, Name, HireDate);
        }
    }

    [DataContract(Name = "Employee2")]
    public class Employee2
    {
        [XmlIgnore]
        public int Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "HireDate")]
        public DateTime HireDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise1_1("employee.xml");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employee.xml"));
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

            using (var writer = XmlWriter.Create(outfile))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            using (var reader = XmlReader.Create(outfile))
            {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;

                Console.WriteLine(employee);
            }
        }

        private static void Exercise1_2(string outfile)
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

            using (var writer = XmlWriter.Create(outfile))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
        }

        private static void Exercise1_3(string outfile)
        {
            using (var reader = XmlReader.Create(outfile))
            {
                var serializer = new XmlSerializer(typeof(Employee[]));
                var employee = serializer.Deserialize(reader) as Employee[];
                foreach (var employees in employee)
                {
                    Console.WriteLine(employees);
                }
            }
        }

        private static void Exercise1_4(string outfilev)
        {
            var emps = new Employee2[]
            {
                new Employee2
                {
                    Id = 123,
                    Name = "井出　幸太郎",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee2
                {
                    Id = 456,
                    Name = "中澤　康介",
                    HireDate = new DateTime(2002, 1, 3),
                },
            };

            //シリアル化
            using (var stream = new FileStream(outfilev, FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(emps.GetType(),new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
                }); 
                serializer.WriteObject(stream, emps);
            }
        }
    }
}
