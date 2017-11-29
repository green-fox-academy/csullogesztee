using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.
            foreach (string nimals in far)
            {
                var animals = new StringBuilder();
                animals.Append(nimals);
                animals.Append("a");

            Console.WriteLine(animals);
            }
            Console.ReadLine();
        }
    }
}