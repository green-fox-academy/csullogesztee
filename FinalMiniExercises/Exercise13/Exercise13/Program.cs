using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        //Create a function that takes a list of strings and transforms it like:

        //[
        //"abc",
        //"ijk",
        //"xyz"
        //]
        //becomes

        //[
        //"aix",
        //"bjy",
        //"ckz"
        //]
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
                "abc",
                "ijk",
                "xyz"
            };

            ListPrinter(SortingString(myList));
            Console.ReadKey();
        }

        static List<string> SortingString(List<string> list)
        {
            List<string> newList = new List<string>();

            for(int i = 0; i < list.Count(); i++)
            {
                string newString = "";
                for(int j = 0; j < list.Count(); j++)
                {
                    newString = newString + list[j][i];
                }
                newList.Add(newString);
            }
            return newList;
        }

        static void ListPrinter(List<string> list)
        {
            foreach(var line in list)
            {
                Console.WriteLine(line);
            }
        }
    }
}
