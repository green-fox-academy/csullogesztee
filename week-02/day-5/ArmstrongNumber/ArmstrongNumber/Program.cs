using System;

namespace ArmstrongNumber

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number");
            string candidate = Console.ReadLine();
            //char[] numbers = candidate.ToCharArray();

            int[] intnumbers = new int[candidate.Length];
            for (int j = 0; j < candidate.Length; j++)
            {
                intnumbers[j] = Convert.ToInt32(candidate[j]);
            }

            int yournumber = int.Parse(candidate);
            double doubleyournumber = Convert.ToDouble(yournumber); 

            double exponent = Convert.ToDouble(candidate.Length);

            double[] doublenumbers = new double[candidate.Length];

            double sum = 0;

            for (int i = 0; i < candidate.Length; i++)
            {
                //intnumbers[i] = Convert.ToInt32(numbers[i]);
               // doublenumbers[i] = Convert.ToDouble(intnumbers[i]);

               // sum = sum + Math.Pow(doublenumbers[i], exponent);
            }

           // if (sum == doubleyournumber)
            {
                Console.WriteLine("The " + yournumber + " is an Armstrong number");
            }
            //else
            {
                Console.WriteLine("The " + yournumber + " isn't an Armstrong number");
            }
            Console.WriteLine("sum" + sum + "exp" + exponent);
            Console.ReadLine();
        }
    }
}
