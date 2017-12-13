using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_letters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string mytext = "abbcccddddeeeeeex";

            foreach (KeyValuePair<char, int> element in Count.LetterCounter(mytext))
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
