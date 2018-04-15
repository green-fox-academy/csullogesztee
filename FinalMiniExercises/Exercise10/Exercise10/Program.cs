using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        //Create a function that takes an array of
        //integers and returns the average of the even numbers from that array
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(Average(EvenNumbers(myArray)));

            Console.ReadKey();
        }

        static List<int> EvenNumbers(int[] arr)
        {
            List<int> list = new List<int>();
            foreach(var number in arr)
            {
                if (number % 2 == 0)
                    list.Add(number);
            }
            return list;
        }

        static double Average(List<int> list)
        {
            return list.Average();
        }
    }
}
