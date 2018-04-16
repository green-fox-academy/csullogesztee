using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        //Create a function that takes two strings and returns an array
        //of characters that consitst all the common letters of the two arrays
        static void Main(string[] args)
        {
            Console.WriteLine("Add first string");
            string text1 = Console.ReadLine();
            Console.WriteLine("Add second string");
            string text2 = Console.ReadLine();

            foreach(var letter in CommonLetters(text1, text2))
            {
                Console.WriteLine(letter);
            }
            Console.ReadKey();
        }

        static char[] CommonLetters(string text1, string text2)
        {
            char[] arr1 = text1.ToCharArray();
            char[] arr2 = text2.ToCharArray();

            List<char> list = new List<char>();
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr2.Contains(arr1[i]))
                    list.Add(arr1[i]);
            }
            return list.Distinct().OrderBy(x=>x).ToArray();
        }
    }
}
