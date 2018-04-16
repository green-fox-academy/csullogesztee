using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        //Create a function that takes an array and a number and shifts the values
        //of the array by the given number like: [1, 2, 3, 4, 5] and 2 becomes [4, 5, 1, 2, 3]
        static void Main(string[] args)
        {
            Console.WriteLine("Add your numbers separate with ,");
            string text = Console.ReadLine();
            Console.WriteLine("Add the first number");
            int number = int.Parse(Console.ReadLine());

            ArrayPrinter(SortedArray(CreateArray(text), number));
            Console.ReadKey();
        }

        static int[] CreateArray(string text)
        {
            string[] arr = text.Split(',');
            int[] intArr = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                intArr[i] = int.Parse(arr[i]);
            }
            return intArr;
        }

        static int[] SortedArray(int[] array, int index)
        {
            List<int> list = new List<int>();

            foreach(var number in array)
            {
                list.Add(number);
            }

            int searchedIndex = list.IndexOf(index);
            List<int> newList = new List<int>();

            for(int i = 0; i < searchedIndex; i++)
            {
                newList.Add(list[i]);
            }
            list.RemoveRange(0, searchedIndex);
            list.AddRange(newList);
            return list.ToArray();
        }

        static void ArrayPrinter(int[] array)
        {
            foreach(var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
