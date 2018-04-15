using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        //Create a function that takes a string and a letter,
        //than returns a list that contains all the indexes where the letter occured in the string.
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text here");
            string text = Console.ReadLine();
            Console.WriteLine("Add the searched letter");
            char letter = Convert.ToChar(Console.ReadLine());

            ListPrinter(Indexes(text, letter));

            Console.ReadKey();
        }

        static List<int> Indexes(string text, char letter)
        {
            List<int> indexes = new List<int>();
            for(int i = 0; i < text.Length; i++)
            {
                if (letter.Equals(text[i]))
                    indexes.Add(i);
            }
            return indexes;
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
