using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the expression:");

            string mytext = Console.ReadLine();
            string[] expressions = mytext.Split(' ');
            char operation = Convert.ToChar(expressions[0]);
            int expression1 = int.Parse(expressions[1]);
            int expression2 = int.Parse(expressions[2]);
            int result = 0;

            if (operation == '+')
            {
                result = expression1 + expression2;
            }
            else if (operation == '-')
            {
                if (expression1 >= expression2)
                {
                    result = expression1 - expression2;
                }
                else
                {
                    Console.WriteLine("The first expression should be the bigger");
                }
            }
            else if (operation == '*')
            {
                result = expression1 * expression2;
            }
            else if (operation == '/')
            {
                result = expression1 / expression2;
            }
            else if (operation == '%')
            {
                result = expression1 % expression2;
            }
            else
            {
                Console.WriteLine("Operation cannot be done");
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
