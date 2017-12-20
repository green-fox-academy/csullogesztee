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
            char[] characters = addedtext.ToCharArray();

            List<char> charactersOfText = new List<char>();

            Dictionary<char, int> NumberOfCharacters = new Dictionary<char, int>();
            NumberOfCharacters.Add(characters[0], 1);

            for (int i = 1; i < characters.Length; i++)
            {
                if (NumberOfCharacters.ContainsKey(characters[i]))
                {
                    NumberOfCharacters[characters[i]]++;
                }
                else
                {
                    NumberOfCharacters.Add(characters[i], 1);
                }
            }
            foreach (KeyValuePair<char, int> element in NumberOfCharacters)
            {
                if (element.Value == 1)
                {
                    charactersOfText.Add(element.Key);
                }
            }

            return charactersOfText;
        }
    }
}