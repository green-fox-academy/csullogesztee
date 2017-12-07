using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int mynumber = 50;
            Counter(mynumber);
            Console.ReadLine();
        }
        public static int Counter(int number)
        {
            Console.WriteLine(number);
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return Counter(number - 1);
            }
        }
    }
}
