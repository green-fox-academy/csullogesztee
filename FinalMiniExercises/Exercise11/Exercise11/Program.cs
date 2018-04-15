using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        //Create a function that takes two strings and decides if one is anagram of the other
        static void Main(string[] args)
        {
            Console.WriteLine("Add first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Add second word");
            string word2 = Console.ReadLine();

            Console.WriteLine(word1 + " and " + word2 + " are anagrams: " + AreTheyAnagrams(word1, word2));
            Console.ReadKey();
        }

        static bool AreTheyAnagrams(string word1, string word2)
        {
            char[] arr1 = word1.ToCharArray();
            Array.Sort(arr1);
            char[] arr2 = word2.ToCharArray();
            Array.Sort(arr2);
            bool theyAreAnagrams = true;

            if(arr1.Length != arr2.Length)
            {
                theyAreAnagrams = false;
            }
            else
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    if(arr1[i] != arr2[i])
                    {
                        theyAreAnagrams = false;
                        break;
                    }
                }
            }
            return theyAreAnagrams;
        }
    }
}
