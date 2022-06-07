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
            //5-1
            Console.WriteLine("パスワードを入力してください");
            var jnputString1 = Console.ReadLine();
            Console.WriteLine("もう一度パスワードを入力してください");
            var jnputString2 = Console.ReadLine();

            if (String.Compare(jnputString1,jnputString2,false)== 0)
            {
                Console.WriteLine("同一のパスワードでないです");
            }            
        }       
    }
}
