using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        //Create a function that takes an array of integers
        //and retunrs the biggest from each of its second elements like:
        //[1, 3, 8, 6, 7, 4] would return 6
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1, 3, 8, 6, 7, 4};

            Console.WriteLine(BiggestNumberInEvenElements(myArray));
            Console.ReadKey();
        }

        static int BiggestNumberInEvenElements(int[] arr)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                    list.Add(arr[i]);
            }
            return list.Max();
        }

    }
}
