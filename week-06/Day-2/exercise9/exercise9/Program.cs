using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[] { 'h', 'e', 'l', 'l', 'o' };

            StringBuilder mytext = characters.Aggregate(new StringBuilder(), (text, next) => text.Append(next));

            Console.WriteLine(mytext);

            Console.ReadKey();
            
            //StringBuilder text = Array.ForEach(characters, letter => text.Append(letter.ToString()));
        }
    }
}
