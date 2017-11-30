using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.WriteLine("Add a number!");
            int number = int.Parse(Console.ReadLine());

            string space = " ";
            string star = "*";
            int spaceNumber = number - 1;
            int starNumber = star.Length;

            for (int i = 0; i <= number; i++)
            {
                if (i < number / 2)
                {
                    for (int j = spaceNumber; j >= 0; j--)
                    {
                        Console.Write(space);
                    }
                   
                    Console.WriteLine(star);

                    star = star + "**";
                    spaceNumber = spaceNumber - 1;
                    starNumber = star.Length; 
                }
                else
                {
                    for (int j = spaceNumber; j >= 0; j--)
                    {
                        Console.Write(space);
                    }
                    for (int k = starNumber - 1; k >= 0; k--)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();

                    //star = star;
                    starNumber = starNumber - 2;
                    spaceNumber = spaceNumber + 1;
                }
            }



            Console.ReadLine();
        }
    }
}