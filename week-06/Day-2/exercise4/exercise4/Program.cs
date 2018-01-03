using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            var filteredNumbers = numbers.Where(n => Math.Pow(n, 2) > 20).OrderBy(m => m);

            //filteredNumbers.ForEach(i => Console.WriteLine($"[{i}]"));

            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
