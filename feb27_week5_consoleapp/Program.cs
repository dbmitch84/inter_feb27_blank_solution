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
            string name = "Mitch";
            SayHello();
            SayGoodbye();
            SayHelloTo(name);
            SayGoodbyeTo(name);
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello!!!");
            Console.WriteLine();// blank line for spacing
        }


        public static void SayGoodbye()
        {
            Console.WriteLine("Ciao (That's fancy for 'goodbye')!!!");
            Console.WriteLine();// blank line for spacing
        }

        public static void SayHelloTo(string name)
        {
            
            Console.WriteLine("Hello {0}!!!",name);
            Console.WriteLine();// blank line for spacing
        }


        public static void SayGoodbyeTo(string name)
        {
            
            Console.WriteLine("Ciao (That's fancy for 'goodbye') {0}!!!", name);
            Console.WriteLine();// blank line for spacing
        }

    }
}
