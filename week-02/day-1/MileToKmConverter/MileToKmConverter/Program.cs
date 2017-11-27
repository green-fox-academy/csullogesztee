using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("What is the distance in kilometers?");
            string distance = Console.ReadLine();
            int distance2 = int.Parse(distance);
            Console.WriteLine("The distance in miles: " + distance2 * 0.621371192);
            Console.Read();
        }
    }
}