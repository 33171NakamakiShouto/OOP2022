using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();
            Console.WriteLine();

        }


        private static void Exercise1_2()
        {
            var books = Library.Books;

            foreach (var m in books)
            {
                if (books.Max(a=>a.Price)== m.Price)
                {
                    Console.WriteLine(m);
                }
            }

        }

        private static void Exercise1_3()
        {
            

        }

        private static void Exercise1_4()
        {

        }

        private static void Exercise1_5()
        {

        }

        private static void Exercise1_6()
        {
           
        }

        private static void Exercise1_7()
        {

        }

        private static void Exercise1_8()
        {

        }
    }
}
