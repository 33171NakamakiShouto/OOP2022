using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers)
        {//最大値
            var max = numbers.Max();
            Console.WriteLine("最大値:{0}",max);
        }

        private static void Exercise1_2(int[] numbers)
        {//最後から２つの要素取り出し
            //var select = numbers.SkipWhile(n => numbers.Length < 9).ToList();
            //select.ForEach(Console.WriteLine);
            /*foreach (var s in numbers.SkipWhile(s => s <= 8))
            {
                Console.WriteLine(s);
            }*/

            foreach (var s in numbers.Skip(numbers.Length-2))
            {
                Console.WriteLine(s);
            }
        }

        private static void Exercise1_3(int[] numbers)
        {//数値を文字列へ変換
            var str = numbers.Select(s=>s.ToString()).ToList();
            str.ForEach(Console.WriteLine);
        }

        private static void Exercise1_4(int[] numbers)
        {//小さい順に並べて先頭の3つを出力
            foreach (var ord in numbers.OrderBy(o => o).Take(3))
            {
                Console.WriteLine(ord);
            }
        }

        private static void Exercise1_5(int[] numbers)
        {//重複を排除し10より大きい数がいくつあるか
            var dis = numbers.Distinct().Count(d => d > 10);
            Console.WriteLine(dis);
        }
    }
}
