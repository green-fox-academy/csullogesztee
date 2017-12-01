using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the the range of the number (minimum and maximum) in two rows!");
            int randommin = int.Parse(Console.ReadLine());
            int randommax = int.Parse(Console.ReadLine());

            Console.WriteLine("How many lives do you want?");
            int lives = int.Parse(Console.ReadLine());

            Random randomnumbers = new Random();
            int randomnumber = randomnumbers.Next(randommin, randommax);

            int yournumber = 0;

                for (int i = 0; i < lives; i++)
                {
               
                    Console.WriteLine("Add a number!");
                    yournumber = int.Parse(Console.ReadLine());

                    if (i < lives - 1 && yournumber != randomnumber)
                    {
                        if (yournumber < randomnumber)
                        {
                            Console.WriteLine("Too low. You have " + (lives - (i+1)) + " lives left.");
                        }
                        else
                        {
                            Console.WriteLine("Too high. You have " + (lives - (i+1)) + " lives left.");
                        }
                    }
                    else if (i == lives - 1 && yournumber != randomnumber)
                    {
                        Console.WriteLine("The end :(");
                    }
                    else
                    {
                        Console.WriteLine("You won!");
                        i = lives - 1;
                    }
                }
            Console.ReadLine();
        }
    }
}
