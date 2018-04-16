using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        //Create a function that takes a list of numbers and returns a
        //new list where all the duplicate values are removed
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> {1, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 9 };

            ListPrinter(RemoveDuplicatedNumbers(numberList));
            ListPrinter(RemoveDuplicatedNumbers2(numberList));

            Console.ReadKey();
        }

        static List<int> RemoveDuplicatedNumbers(List<int> list)
        {
            return list.Distinct().ToList();
        }

        static List<int> RemoveDuplicatedNumbers2(List<int> list)
        {
            List<int> newList = new List<int>();

            for(int i = 0; i < list.Count(); i++)
            {
                if (!newList.Contains(list[i]))
                    newList.Add(list[i]);
            }
            return newList;
        }

        static void ListPrinter(List<int> list)
        {
            foreach(var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
