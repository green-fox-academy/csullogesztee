using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.WriteLine("Add a number!");
            string addnumber = Console.ReadLine();
            int addnumberint = int.Parse(addnumber);
            Console.WriteLine(Factorio(addnumberint));
            Console.ReadLine();
        }

        public static int Factorio(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)

            {  
                factorial *= i;
            }
            return factorial;
        }
    }
}