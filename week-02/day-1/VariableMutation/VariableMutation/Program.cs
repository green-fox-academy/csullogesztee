using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a + 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b - 7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c * 2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d / 5);

            int e = 8;
            // please cube of e's value
            // double number1 = Math.Pow(number, 2); = number^2

            Console.WriteLine(e * e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool smaller = false;
            bool bigger = true;

            if (f1 > f2)
            {
                Console.WriteLine(bigger);
            }
            else
            {
                Console.WriteLine(smaller);
            }

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            if (2 * g2 > g1)
            {
                Console.WriteLine(bigger);
            }
            else
            {
                Console.WriteLine(smaller);
            }

            Int64 h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)
            double divisor = h % 11;
            if (divisor == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            double squared = Math.Pow(i2, 2);
            double cubed = Math.Pow(i2, 3);

            if (i1 > squared && i1 < cubed)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            double three = j % 3;
            double five = j % 5;
            double multiple = three * five;

            if (multiple > 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }

            string k = "Apple";
            //fill the k variable with its cotnent 4 times
            for (int i = 1; i<=3; i++)
            {
                Console.WriteLine(k);
            }
           

            Console.WriteLine(k);
            Console.Read();
        }
    }
}