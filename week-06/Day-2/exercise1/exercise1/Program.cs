using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              orderby n
                              select n;

            var evenNumbers2 = numbers.Where(m => (m % 2 == 0)).OrderBy(m => m);

            Console.WriteLine("Query Syntax:");
            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("Method Syntax:");
            foreach (var evenNumber in evenNumbers2)
            {
                Console.WriteLine(evenNumber);
            }

            Console.ReadKey();
        }
    }
}
