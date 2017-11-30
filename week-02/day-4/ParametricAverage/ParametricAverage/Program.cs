using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
            
            
           
                Console.WriteLine("Add a number");
                int number = int.Parse(Console.ReadLine());
            int justforworking = 0;
            double forave = 1;

            while (justforworking < 5)
            {
                Console.WriteLine("Add a number");
                int newnumber = int.Parse(Console.ReadLine());

                number = number + newnumber;
                int sum = number;
                forave = forave + 1;
                double sumforave = Convert.ToDouble(sum);
                double ave = sumforave / forave;

                Console.WriteLine("Sum: " + sum + ", Average: " + ave);
            }
            Console.ReadLine();
        }
    }
}