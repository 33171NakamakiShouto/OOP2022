using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            //var books = Library.Books
            //    .OrderBy(b => b.CategoryId)
            //    .ThenByDescending(b=>b.PublishedYear)
            //    .ThenBy(b=>b.Price);
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}
            //
            Console.WriteLine("出力したい西暦を入力(終了:-1)");

            var years = new List<int>();
            var year = int.Parse(Console.ReadLine());
            var books = Library.Books
                               .Where(b => years.Contains(b.PublishedYear));

            while (!(year == -1))
            {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("昇順:1　降順:2 => ");

            var order = int.Parse(Console.ReadLine());

            if (order == 1)
            {
                foreach (var book in books.OrderBy(b => b.PublishedYear))
                {
                    Console.WriteLine(book);
                }
            }
            else if (order == 2)
            {

                foreach (var book in books.OrderByDescending(b => b.PublishedYear))
                {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine();

            var selected = Library.Books
                          .Where(b => years.Contains(b.PublishedYear))
                          .OrderByDescending(b => b.PublishedYear)
                          .ThenBy(b => b.CategoryId)
                          .Join(Library.Categories,//結合する2番目のシーケンス
                                book => book.CategoryId,//対象シーケンスの結合キー
                                category => category.Id,//2番目のシーケンスの結合キー
                                (book, category) => new
                                {
                                    Title = book.Title,
                                    Category = category.Name,
                                    PublishedYear = book.PublishedYear,
                                    Price = book.Price,
                                }
                           );
            foreach (var g in selected)
            {
                Console.WriteLine($"出版年:{g.PublishedYear},タイトル:{g.Title},カテゴリ:{g.Category},　{g.Price}円");                 
            }
            Console.WriteLine($"金額の合計{selected.Sum(s => s.Price)}");
        }
    }
}
