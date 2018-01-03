using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var filteredCities = cities.Where(city => city[0] == 'A' || city.Last() == 'I');

            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }

            Console.ReadKey();
        }
    }
}
