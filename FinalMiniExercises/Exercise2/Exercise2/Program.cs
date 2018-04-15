using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //Create a function that reverses a string
        static void Main(string[] args)
        {
            string myString = "reversestring";
            Console.WriteLine(Reverser1(myString));
            Console.WriteLine(Reverser2(myString));

            Console.ReadKey();
        }

        static string Reverser1(string stringToReversed)
        {
            char[] chars = stringToReversed.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static string Reverser2(string stringToReversed)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = stringToReversed.Length-1; i >= 0; i--)
            {
                sb.Append(stringToReversed[i]);
            }

            return sb.ToString();
        }
    }
}
