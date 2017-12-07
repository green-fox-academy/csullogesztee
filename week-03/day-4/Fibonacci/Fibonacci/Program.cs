using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number!");
            int mynumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The " + mynumber + "th Fibonacci number is: " + Fibonacci(mynumber));
            Console.ReadLine();
        }
        public static int Fibonacci(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }
    }
}
