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
            var jnputstring = Console.ReadLine();
            int jnputint;
            if (int.TryParse(jnputstring, out jnputint))
            {
                Console.WriteLine(string.Format("{0:N}\r\n", jnputint));
            }
        }
    }
}
