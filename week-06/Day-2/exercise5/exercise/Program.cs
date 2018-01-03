using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbers = numbers.OrderBy(n => n).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            foreach (var item in frequencyOfNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
