using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string mytext1 = "dog";
            string mytext2 = "god";

            bool result = AnagramCheck.AnagramChecker(mytext1, mytext2);

            Console.WriteLine("The two text is anagram of each other: " + result);
            Console.ReadLine();
        }
    }
    public class AnagramCheck
    {
        public static bool AnagramChecker(string text1, string text2)
        {
            bool solution = false;
            if (text1.Length == text2.Length)
            {
                char[] text1arr = text1.ToCharArray();
                char[] text2arr = text2.ToCharArray();
                Array.Sort(text1arr);
                Array.Sort(text2arr);
                foreach (char letter1 in text1arr)
                {
                    foreach (char letter2 in text2arr)
                    {
                        if (letter1 == letter2)
                        {
                            solution =  true;
                        }
                        else
                        {
                            solution = false;
                        }
                    }
                }
            }
            else
            {
                solution = false;
            }
            return solution;
        }
    }
}
