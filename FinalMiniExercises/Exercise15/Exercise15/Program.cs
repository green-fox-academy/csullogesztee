using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        //Create a function that takes a string and splits it to a list of two
        //character strings like: "abcdef" becomes ["ab", "cd", "ef"]
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text");
            string myString = Console.ReadLine();

            ListPrinter(MakeList(myString));
            Console.ReadKey();
        }

        static List<string> MakeList(string text)
        {
            List<string> list = new List<string>();

            for(int i = 0; i < text.Length; i+=2)
            {
                list.Add(text[i].ToString() + text[i + 1]);
            }
            return list;
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
