using System;

namespace ArmstrongNumber

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number");
            string input = Console.ReadLine();

            List<int> candidate = new List<int>();

            foreach (var digitStr in input)
            {
                int digit = Int32.Parse(digitStr.ToString());

                candidate.Add(digit);
            }

            int yournumber = int.Parse(input);
            double doubleyournumber = Convert.ToDouble(yournumber); 

            double exponent = Convert.ToDouble(candidate.Count);

            double[] doublenumbers = new double[candidate.Count];

            double sum = 0;

            for (int i = 0; i < candidate.Count; i++)
            {
                intnumbers[i] = Convert.ToInt32(numbers[i]);
                doublenumbers[i] = Convert.ToDouble(intnumbers[i]);

                sum = sum + Math.Pow(doublenumbers[i], exponent);
            }

            if (sum == doubleyournumber)
            {
                Console.WriteLine("The " + yournumber + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine("The " + yournumber + " isn't an Armstrong number");
            }
            Console.WriteLine("sum" + sum + "exp" + exponent);
            Console.ReadLine();
        }
    }
}
