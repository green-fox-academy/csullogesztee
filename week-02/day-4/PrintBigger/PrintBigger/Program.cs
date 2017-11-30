using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Add two number (in two row)!");
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());

            if (firstnumber < secondnumber)
            {
                Console.WriteLine(secondnumber);
            }
            else
            {
                Console.WriteLine(firstnumber);
            }

            Console.ReadLine();
        }
    }
}