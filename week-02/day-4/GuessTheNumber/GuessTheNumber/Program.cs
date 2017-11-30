using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
            int original = 123;
            int number = 1;

            while (number != original)
            {
                Console.WriteLine("Add a number!");
                number = int.Parse(Console.ReadLine());

                if (number < original)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else if (number > original)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else
                {
                    Console.WriteLine("You found the number: " + original);
                }
            }
            Console.ReadLine();
        }
    }
}
