using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positiveNumbers = from n in numbers
                                  where n > 0
                                  orderby n
                                  select n;

            var positiveNumbers2 = numbers.Where(m => (m > 0)).OrderBy(m => m).Select(m => Math.Pow(m, 2));

            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(Math.Pow(number, 2));
            }

            foreach (var number in positiveNumbers2)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
