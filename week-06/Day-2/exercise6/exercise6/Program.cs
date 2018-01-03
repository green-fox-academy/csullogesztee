using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text here!");
            string mystring = Console.ReadLine();

            var frequencyOfLetters = mystring.OrderBy(n => n).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            Console.WriteLine("The letters of your text:");
            foreach (var item in frequencyOfLetters)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
