using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        //Create a function that takes a list of strings and a letter and returns
        //a string where the strings are joined with the given letter like: ["ab", "cde", "fg"]
        //and " " becomes "ab cde fg"
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            { "aa", "bb", "cc", "dd"};

            Console.WriteLine(JoinedString(myList));
            Console.ReadKey();
        }

        static string JoinedString(List<string> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var line in list)
            {
                sb.Append(line);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
