using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddNumbers = from n in numbers
                             where Math.Abs(n) % 2 == 1
                             orderby n
                             select n;
            double average = oddNumbers.Average();

            var oddNumbers2 = numbers.Where(m => (Math.Abs(m) % 2 == 1)).OrderBy(m => m).Average();

            Console.WriteLine("With query syntax:");
            Console.WriteLine("The average of our odd numbers is: " + average);
            Console.WriteLine("With method syntax:");
            Console.WriteLine("The average of our odd numbers is: " + oddNumbers2);

            Console.ReadKey();
        }
    }
}
