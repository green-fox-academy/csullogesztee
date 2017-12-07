using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the number of the bunnies!");
            int numberofthebunnies = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of the ears of the bunnies is: " + EarCounter(numberofthebunnies));
            Console.ReadLine();
        }
        public static int EarCounter(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return EarCounter(number - 1) + 2;
            }
        }
    }
}
