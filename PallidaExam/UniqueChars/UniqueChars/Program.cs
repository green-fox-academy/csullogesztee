using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniqueChars
    {
        public static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            Console.WriteLine("Add your text!");
            string mytext = Console.ReadLine();

            foreach (char element in Unique.UniqueCharacters(mytext))
            {
                Console.Write("\"" + element + "\", ");
            }

            Console.ReadKey();
        }

    }
        public class Unique
        {
            public static List<char> UniqueCharacters(string addedtext)
            {
                List<char> charactersOfText = new List<char>();

                char[] characters = addedtext.ToCharArray();

                foreach (char character in characters)
                {
                    charactersOfText.Add(character);
                }

                return charactersOfText;
            }
        }
}