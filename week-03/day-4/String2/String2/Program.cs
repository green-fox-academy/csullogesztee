using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text!");
            string mytext = Console.ReadLine();
            Console.WriteLine(Replace(mytext));
            Console.ReadLine();
        }
        static string Replace(string text)
        {
            if (text.Length == 0)
            {
                return "";
            }
            if (text[0] == 'x')
            {
                text = "" + text.Substring(1);
            }

            return text[0] + Replace(text.Substring(1));
        }
    }
}
