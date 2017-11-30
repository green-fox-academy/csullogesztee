using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens do you have?");
            string chicken = Console.ReadLine();
            int intchicken = int.Parse(chicken);
            Console.WriteLine("How many pig do you have?");
            string pig = Console.ReadLine();
            int intpig = int.Parse(chicken);

            int legs = 4 * intpig + 2 * intchicken;

            Console.WriteLine("Your animals have " + legs + " legs");
            Console.ReadLine();
        }
    }
}