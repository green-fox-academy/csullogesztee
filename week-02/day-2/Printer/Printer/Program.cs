using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
            string[] howmany = {"first", "second", "third"};
            Printer(howmany);
            Console.ReadLine();
        }
        public static void Printer(string[] nth)
            {
            foreach (string element in nth)
            Console.WriteLine(element);
        }
    }
}