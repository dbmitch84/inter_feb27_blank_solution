using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb27_week5_consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello!!!");
        }


        public static void SayGoodbye()
        {
            Console.WriteLine("Ciao (That's fancy for 'goodbye')!!!");
        }
    }
}
