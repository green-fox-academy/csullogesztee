using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number!");
            int mynumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Add the exponent!");
            int myexponent = int.Parse(Console.ReadLine());

            Console.WriteLine("The power of your number is: " + PowerN(mynumber, myexponent));
            Console.ReadLine();
        }
        public static int PowerN(int number, int exponent)
        {
            
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return PowerN(number, exponent - 1) * number;
            }
        }
    }
}
