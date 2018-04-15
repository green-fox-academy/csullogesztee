using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //Create a function that returns how many letters in the word: "duck" (it is four)
        static void Main(string[] args)
        {
            Console.WriteLine("Add your word here!");
            string myString = Console.ReadLine();

            Console.WriteLine("The number of the letters in the word: " + NumberOfChars(myString));
            Console.ReadKey();
        }

        static int NumberOfChars(string randomWord)
        {
            return randomWord.Length;
        }
    }
}
