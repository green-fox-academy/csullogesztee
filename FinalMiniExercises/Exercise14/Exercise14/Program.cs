using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        //Create a function takes a string and a letter and splits the string
        //to an list of strings by the letter like: "a,bcd,e,fg" and ',' becomes ["a", "bcd", "e", "fg"]
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text");
            string text = Console.ReadLine();
            Console.WriteLine("Add the separator");
            char letter = Convert.ToChar(Console.ReadLine());

            ListPrinter(SortedList(text, letter));
            Console.ReadKey();
        }

        static List<string> SortedList(string text, char letter)
        {
            string[] stringArray = text.Split(letter);
            List<string> newList = new List<string>();

            foreach (var line in stringArray)
            {
                newList.Add(line);
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
