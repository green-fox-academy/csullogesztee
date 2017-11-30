using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            string pile1 = "%";
            string pile2 = " ";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(pile1);
                        }
                        else
                        {
                            Console.Write(pile2);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(pile2);
                        }
                        else
                        {
                            Console.Write(pile1);
                        }
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}