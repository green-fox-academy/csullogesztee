using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text!");
            string mytext = Console.ReadLine();
            Console.WriteLine(Addstar(mytext));
            Console.ReadLine();
        }
        static string Addstar(string text)
        {
            if (text.Length == 0)
            {
                return "";
            }
            if(text.Length == 1)
            {
                return text;
            }
            else
            {
                return text[0] +  "*" + Addstar(text.Substring(1));
            }

        }
    }
}
