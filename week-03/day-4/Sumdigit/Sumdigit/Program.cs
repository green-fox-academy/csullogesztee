using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number!");
            int mynumber = int.Parse(Console.ReadLine());
            int sumofdigits = 0;
            Console.WriteLine("The sum of the digits of your number:" + SumDigit(mynumber, sumofdigits));
            Console.ReadLine();
        }
        public static int SumDigit(int number, int sum)
        {
            if (number == 0)
            {
                return sum;
            }
            else
            {
                sum = sum + number % 10;
                return SumDigit((number) / 10, sum);
            }
        }
    }
}
