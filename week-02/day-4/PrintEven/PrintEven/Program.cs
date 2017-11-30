
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500
            for (int i = 0; i <= 500; i = i +2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}