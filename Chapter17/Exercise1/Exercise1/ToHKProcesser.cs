using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1
{
    class ToHKProcesser : TextProcessor
    {
        protected override void Initialize(string fname){}

        protected override void Execute(string line)
        {
            Console.WriteLine(Strings.StrConv(line, VbStrConv.Narrow));
            //Console.WriteLine(line);
        }

        protected override void Terminate(){}
    }
}
