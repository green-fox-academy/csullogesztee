using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            string cheat = "I won't cheat on the exam!";
            for (int i = 1; i <= 99; i++)
            {
                Console.WriteLine(cheat);
            }
           
            Console.Read();
        }
    }
}