using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        //Create a function that takes two arrays
        //and mixes them like this: [1, 2, 3] and [6, 7, 8] becomes [1, 6, 2, 7, 3, 8]
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 6, 7, 8 };

            foreach(var number in JoinedArrays(array1, array2))
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

        static int[] JoinedArrays(int[] arr1, int[] arr2)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < arr1.Length; i++)
            {
                list.Add(arr1[i]);
                list.Add(arr2[i]);
            }
            return list.ToArray();
        }
    }
}
