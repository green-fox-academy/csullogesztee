using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSomeNumber
{
     public class Program
    {

        static void Main(string[] args)
        {


            List<int> mynumbers = new List<int>();
            mynumbers.Add(1);
            mynumbers.Add(2);
            mynumbers.Add(3);
            mynumbers.Add(4);
            mynumbers.Add(5);

            Console.WriteLine(Sum.SumNumbers(mynumbers));
            Console.ReadLine();

        }
    }
    public class Sum
    {
        public static int SumNumbers(List<int> numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
            foreach (int number in numbers)
            {
                result = result + number;
            }
            return result;
            }
        }
    }
}

