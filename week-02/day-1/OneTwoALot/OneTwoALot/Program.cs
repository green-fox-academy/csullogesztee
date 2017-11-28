using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            Console.WriteLine("Please, write a number!");
            string number = Console.ReadLine();
            int numberint = Convert.ToInt32(number);
            // If the number is zero or smaller it should print: Not enough
            if (numberint < 0)
            {
                Console.WriteLine("Not enough");
            }
            // If the number is one it should print: One
            else if (numberint == 1)
            {
                Console.WriteLine("One");
            }
            // If the number is two it should print: Two
             else if (numberint == 2)
            {
                Console.WriteLine("Two");
            }
            // If the number is more than two it should print: A lot
            else
            {
                Console.WriteLine("A lot");
            }
            Console.Read();
        }
    }
}