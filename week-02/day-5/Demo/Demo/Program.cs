using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number!");
            int number = int.Parse(Console.ReadLine());

            string percentage = "%";


            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                Console.Write(percentage);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}