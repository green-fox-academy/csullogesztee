using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number!");
            int mynumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers 1 - " + mynumber + ": " + NumberAdder(mynumber));
            Console.ReadLine();
        }
        public static int NumberAdder(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number + NumberAdder(number - 1);
            }
        }
    }
}
