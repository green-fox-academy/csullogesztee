using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.
            Console.WriteLine("Write a number!");
            string number = Console.ReadLine();
            int number2 = int.Parse(number);

            if (number2 % 2 != 1)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.Read();
            

        }
    }
}