using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01
{
    class GreetingMorning : IGreeting
    {
        public string GetMessage()
        {
            return "おさほう";
        }
    }

    class GreetingAfternooon : IGreeting
    {
        public string GetMessage()
        {
            return "こんにちは";
        }
    }

    class GreetingEvening : IGreeting
    {
        public string GetMessage()
        {
            return "こんばんは";
        }
    }
}
