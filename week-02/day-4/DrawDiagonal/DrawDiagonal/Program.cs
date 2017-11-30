using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("Add a number!");
            int number = int.Parse(Console.ReadLine());
            string percentage = "%";

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == 0 || i == number - 1)
                    {
                        Console.Write(percentage);
                    }
                    else if (j == 0 || j == number - 1 || i == j)
                    {
                        Console.Write(percentage);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}