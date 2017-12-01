using System;
using System.Linq;
using System.Text;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a world!");
            string word = Console.ReadLine();

            string reversedword = Reverser(word);

            var builtword = new StringBuilder(word + reversedword);

            Console.WriteLine(builtword);
            Console.ReadLine();

        }
        public static string Reverser(string addastring)
        {
            char[] array = addastring.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
