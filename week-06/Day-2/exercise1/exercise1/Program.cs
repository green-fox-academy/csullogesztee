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

            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

            Console.ReadKey();
        }
    }
}
