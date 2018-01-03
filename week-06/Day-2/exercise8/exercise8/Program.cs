using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add your text here!");
            string mystring = Console.ReadLine();

            var UppercaseCharacters = mystring.ToCharArray().Where(letter => char.IsLetter(letter) && letter.ToString() == letter.ToString().ToUpper());

            foreach (var letter in UppercaseCharacters)
            {
                Console.WriteLine(letter);
            }

            Console.ReadKey();
        }
    }
}
