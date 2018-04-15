using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        //Create a function that takes two arrays and decides if their content is the same
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 1, 2, 3 };
            int[] array3 = new int[] { 3, 2, 1 };
            int[] array4 = new int[] { 1, 2, 3, 4 };
            int[] array5 = new int[] { 4, 5, 6 };

            Console.WriteLine(isTheSame(array1, array2));
            Console.WriteLine(isTheSame(array1, array3));
            Console.WriteLine(isTheSame(array1, array4));
            Console.WriteLine(isTheSame(array1, array5));

            Console.ReadKey();
        }

        static bool isTheSame(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);
            bool isTheSame = true;

            if(array1.Length != array2.Length)
            {
                isTheSame = false;
            }
            else
            {
                for(int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                        isTheSame = false;
                }
            }
            return isTheSame;
        }
    }
}
