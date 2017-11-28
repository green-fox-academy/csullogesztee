using System;

namespace Doubling
{
    class Program
    {
        // - Create a function called `doubling` that doubles it's input parameter
      

        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            int ak = 123;
        
        // - Print the result of `doubling(ak)`
        Console.WriteLine(doubling(ak));
            Console.ReadLine();
        }
        public static int doubling(int num1)
        {
            return  (2 * num1);
        }
    }
}
