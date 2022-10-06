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
            var max = Library.Books.Max(b=>b.Price);
            var books = Library.Books.First(o => o.Price == max);
            Console.WriteLine(books);

        }

        private static void Exercise1_3()
        {
            var books = Library.Books
                .GroupBy(b => b.PublishedYear)
                .OrderBy(o => o.Key);

            foreach (var o in books)
            {
                Console.WriteLine($"{o.Key}年 {o.Count()}冊");
            }
        }

        private static void Exercise1_4()
        {
            var books = Library.Books
                .OrderByDescending(b => b.Price)
                .OrderByDescending(o => o.PublishedYear);
            foreach (var o in books)
            {
                Console.WriteLine(o);
            }
        }

        private static void Exercise1_5()
        {
            var books = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                        book => book.CategoryId,
                        category => category.Id,
                        (book, category) => category.Name)
                .Distinct();
            foreach (var o in books)
            {
                Console.WriteLine(o);
            }
        }

        private static void Exercise1_6()
        {
            var books = Library.Books
                 .Join(Library.Categories,
                         book => book.CategoryId,
                         category => category.Id,
                         (book, category) => new
                         {
                            Category = category.Name,
                            Title = book.Title
                         })

                 .GroupBy(b => b.Category)
                 .OrderBy(o => o.Key);
            foreach (var o in books)
            {
                Console.WriteLine(o.Key);
                foreach (var k in o)
                {
                    Console.WriteLine($"    {k.Title}");
                }
            }
        }

        private static void Exercise1_7()
        {
            var books = Library.Books
                .Where(b => b.CategoryId == 1)
                .GroupBy(b => b.PublishedYear)
                .OrderBy(o => o.Key);
            foreach (var book in books)
            {
                Console.WriteLine($"#{book.Key}");
                foreach (var bok in book)
                {
                    Console.WriteLine($"    {bok}");
                }
            }
        }

        private static void Exercise1_8()
        {
            var books = Library.Categories
                .GroupJoin(Library.Books,
                    c => c.Id,
                    b => b.CategoryId,
                    (c, b) => new
                    {
                        Category = c.Name,
                        Count = b.Count()
                    });
            foreach (var book in books.Where(b=> b.Count >= 4))
            {
                Console.WriteLine(book.Category);

            }
             
        }
    }
}
