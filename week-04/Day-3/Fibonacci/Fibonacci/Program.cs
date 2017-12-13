using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nthFibonacci = 12;

            Console.WriteLine("The " + nthFibonacci + " Fibonacci number is: " + FibonacciNumber.Fibonacci(nthFibonacci));
            Console.ReadLine();
        }
    }
}
