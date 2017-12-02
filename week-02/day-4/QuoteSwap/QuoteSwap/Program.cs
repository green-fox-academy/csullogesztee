using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.
            // full quote: "What I cannot create, I do not understand"

            string cannot = list[5];
            list.RemoveAt(5);
            list.Insert(2, cannot);

            string doo = list[3];
            list.RemoveAt(3);
            list.Insert(5, doo);

            foreach (string word in list)
            {
                Console.Write(word + " ");
            }

            Console.ReadLine();
        }
    }
}