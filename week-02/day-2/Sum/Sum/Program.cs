using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.WriteLine("Add a number!");
            string addnumber = Console.ReadLine();
            int addnumberint = int.Parse(addnumber);
            Console.WriteLine(Sum(addnumberint));
            Console.ReadLine();
        }

        public static int Sum(int number)
        {
        return (number* (number + 1)) / 2;
        }
        
    }
}