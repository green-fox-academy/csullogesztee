using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            Console.WriteLine("Give the parameters of three sides of the cuboidwith \",\"!");
            string sides = Console.ReadLine();
            string[] sidesofthecuboid = sides.Split(',');

            int aside = int.Parse(sidesofthecuboid[0]);
            int bside = int.Parse(sidesofthecuboid[1]);
            int cside = int.Parse(sidesofthecuboid[2]);

            int surface = 2 * (aside * bside + aside * cside + bside * cside);
            int volume = aside * bside * cside;

            Console.WriteLine("Surface: " + surface + "\n" + "Volume: " + volume);
            Console.ReadLine();
        }
    }
}