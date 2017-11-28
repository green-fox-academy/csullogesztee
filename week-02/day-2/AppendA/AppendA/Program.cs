using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            string am = "kuty";
            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`
            AppendA(am);
            Console.ReadLine();
        }
        public static void AppendA(string word)
        {
            Console.WriteLine(word + "a");
        }
    }
}