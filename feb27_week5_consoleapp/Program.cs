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
            
            string name = "Mitch";
            SayHelloTo(name);
            SayGoodbyeTo(name);

            
            int sum2 = Sum(3,55);
            Console.WriteLine("Your answer = "+sum2);
            Console.WriteLine();// blank line for spacing

            int a = 3;
            int b = 55;
            Console.WriteLine();
            Sum(a,b);

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

        public static int Sum(int a, int b)
        {
            Console.WriteLine();// blank line for spacing
            return (a + b);       
        }

    }
}
