using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Add a number for divisor!");
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine("10 / " + divisor + " : " + result);
            }
            catch
            {
                Console.WriteLine("fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
