using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    class Program
    {
        //Create a function that takes an array of integers and returns
        //a new one consisting only those numbers that occured minimum twice in the original array
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1, 2, 2, 3, 3, 3, 4, 5, 5};

            foreach(var number in DuplicatedNumbers(numbers))
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

        static int[] DuplicatedNumbers(int[] numbers)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if(dictionary.ContainsKey(numbers[i]))
                {
                    dictionary[numbers[i]]++;
                }
                else
                {
                    dictionary.Add(numbers[i], 1);
                }
            }

            List<int> newList = new List<int>();

            foreach (var element in dictionary)
            {
                if (element.Value >= 2)
                    newList.Add(element.Key);
            }
            return newList.ToArray();
        }
    }
}
