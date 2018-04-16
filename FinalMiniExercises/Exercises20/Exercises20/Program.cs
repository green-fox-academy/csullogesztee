using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises20
{
    class Program
    {
        //Create a function that takes a list of numbers and returns the second biggest element from it
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<int> numberList2 = new List<int> { 1, 3, 5, 4, 2, 6, 9, 8, 7};

            Console.WriteLine(SecondBiggestNumber(numberList));
            Console.WriteLine(SecondBiggestNumber(numberList2));

            Console.ReadKey();
        }

        static int SecondBiggestNumber(List<int> list)
        {
            return list.OrderByDescending(x => x).ToList()[1];
        }
    }
}
