using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        //Create a function that takes two list of numbers and returns a
        //new list that only consists those numbers that are in the first array but not in the second
        static void Main(string[] args)
        {
            List<int> listOne = new List<int> { 1, 2, 3, 4, 5, 6, 0 };
            List<int> listTwo = new List<int> { 4, 5, 6, 7, 8, 9 };

            ListPrinter(JustInOneList(listOne, listTwo));
            Console.ReadKey();
        }

        static List<int> JustInOneList(List<int> list1, List<int> list2)
        {
            List<int> newList = new List<int>();
            for(int i = 0; i < list1.Count(); i++)
            {
                if (!list2.Contains(list1[i]))
                    newList.Add(list1[i]);
                    
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
