using System;
using System.Text;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("Add a number!");
            int number = int.Parse(Console.ReadLine());

            string space = " ";
            string star = "*";
            int spaceNumber = number - 1;

            for (int i = 0; i < number; i++)
            {

                for (int j = spaceNumber; j >= 0; j--)
                {
                    Console.Write(space);
                }
                //for (int k = 1; k <= number; k++)
                //{
                //    Console.WriteLine(star);
                //}

                Console.WriteLine(star);

                star = star + "**";
                spaceNumber = spaceNumber - 1;
            }



            Console.ReadLine();
        }
    }
}