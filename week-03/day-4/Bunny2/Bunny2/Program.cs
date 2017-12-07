using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the number of the bunnies!");
            int numberofthebunnies = int.Parse(Console.ReadLine());
            Console.WriteLine("The seeming number of the ears of the bunnies is: " + EarsCounter(numberofthebunnies));
            Console.ReadLine();
        }
        public static int EarsCounter(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                if (number % 2 == 0)
                {
                    return EarsCounter(number - 1) + 3;
                }
                else
                {
                    return EarsCounter(number - 1) + 2;
                }
            }
        }
    }
}
