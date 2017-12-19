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
            bool solution = true;
            if (text1.Length == text2.Length)
            {
                char[] text1arr = text1.ToCharArray();
                char[] text2arr = text2.ToCharArray();
                Array.Sort(text1arr);
                Array.Sort(text2arr);
                for (int i = 0; i < text1.Length; i++)
                {
                    if (text1arr[i] == text2arr[i])
                    {
                        solution = true;
                    }
                    if (text1arr[i] != text2arr[i])
                    {
                        solution = false;
                        break;
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
