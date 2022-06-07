using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var ym = new YearMonth(2002, 11);
            var check = ym.Is21Century;
            var test = ym.AddOneMoth();

            Console.WriteLine(ym.ToString());*/

            //4.2.1
            var ymCollection = new YearMonth[]
            {
                new YearMonth(2002,10),
                new YearMonth(2020,4),
                new YearMonth(2098,12),
                new YearMonth(1986,1),
                new YearMonth(2053,6),
            };
            Console.WriteLine("-----------------------");
            Console.WriteLine("         4.2.2         ");
            Console.WriteLine("-----------------------");
            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         4.2.4         ");
            Console.WriteLine("-----------------------");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         4.2.5         ");
            Console.WriteLine("-----------------------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         4.2.6         ");
            Console.WriteLine("-----------------------");

            Exercise2_6(ymCollection);
            Console.WriteLine("-----------------------");

        }

        private static void Exercise2_6(YearMonth[] ymCollection)
        {    //①月で昇順に出力②偶数年のみ昇順に出力③閏年のみを出力④すべての年から12月に一番近い月を出力

            /*①foreach (var ym in ymCollection.OrderBy(ym => ym.Month))
            {
                Console.WriteLine(ym);
            }*/
            /*②foreach (var ym in ymCollection.Where(ym=>ym.Year%2==0 ).OrderBy(ym => ym.Month))
            {
                Console.WriteLine(ym);
            }*/
            /*③foreach (var ym in ymCollection.Where(ym=> DateTime.IsLeapYear(ym.Year)))
            {
                Console.WriteLine(ym);
            }*/
            /*④*/foreach (var ym in ymCollection.Where(ym=> DateTime.IsLeapYear(ym.Year)))
            {
                Console.WriteLine(ym);
            }

            var date = ymCollection.Max(ym=>ym.Month);
            Console.WriteLine(date);
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                if (ym.Is21Century)
                {
                    return ym;
                }
            }
            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection)
        {
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection)
        {
            var ff21 = FindFirst21C(ymCollection);

            if (ff21 != null)
            {
                Console.WriteLine(ff21);
            }
            else
            {
                Console.WriteLine("21世紀のデータがありません");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMoth()).ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }
    }
}
