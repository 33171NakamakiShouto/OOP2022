using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = "Jackdaws love my big sphinx of quartz";
            

            Console.WriteLine("-----------------------");
            Console.WriteLine("         5.3.1         ");
            Console.WriteLine("-----------------------");
            //5.3.1
            Exercise3_1(text);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         5.3.2         ");
            Console.WriteLine("-----------------------");

            //5.3.2
            Exercise3_2(text);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         5.3.3         ");
            Console.WriteLine("-----------------------");

            //5.3.3
            Exercise3_3(text);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         5.3.4         ");
            Console.WriteLine("-----------------------");

            //5.3.4
            Exercise3_4(text);
            Console.WriteLine("-----------------------");
            Console.WriteLine("         5.3.5         ");
            Console.WriteLine("-----------------------");
            //5.3.5
            Exercise3_5(text);
            Console.WriteLine("-----------------------");
        }        

        private static void Exercise3_1(string text)
        {
            var count = text.Count(s => s == ' ');
            Console.WriteLine("空白数:{0}",count);
        }

        private static void Exercise3_2(string text)
        {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text)
        {
            string[] words = text.Split(' ');
            Console.WriteLine("単語数:{0}", words.Length);
            
        }

        private static void Exercise3_4(string text)
        {
            /*var count = 0;
            string[] words = text.Split(' ');
            foreach (var w in words)
            {
                foreach (var ww in w)
                {
                    count++;
                }

                if (count <= 4)
                {
                    Console.WriteLine(w);
                }

                count = 0;
            }*/

            /*text.Split(' ').Where(w => w.Length <= 4)
                .ToList().ForEach(w => Console.WriteLine(w));*/  //一行バージョン
            string[] words = text.Split(' ');
            foreach (var w in words.Where(w => w.Length <= 4))//Where　==> 条件を満たしたら出力
            {
                Console.WriteLine(w);
            }
        }

        private static void Exercise3_5(string text)
        {
            /*var sb = new StringBuilder();
            string[] words = text.Split(' ');
            var count = words.Length - 1;
            foreach (var w in words)
            {
                sb.Append(w);
                if (count > 0)
                {
                    sb.Append(" ");
                    count--;
                }
            }

            Console.WriteLine(sb);*/

            var array = text.Split(' ').ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }

                var str = sb.ToString();
                Console.WriteLine(str);
            }

           
        }
    }
}
