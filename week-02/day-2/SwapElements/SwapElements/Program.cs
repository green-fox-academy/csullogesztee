using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            string[] abc = { "first", "second", "third" };
            // - Swap the first and the third element of `abc`
            for (int i = 0; i < abc.Length; i++)
            {
                string swap = abc[0];
                abc[0] = abc[2];
                abc[2] = swap; 
            }
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }
            
            Console.ReadLine();
        }
    }
}