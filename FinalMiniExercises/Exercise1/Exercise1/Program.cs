using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //Create a function that takes a matrix (list of lists) of numbers and sums all the numbers.
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int> {1, 2, 3},
                new List<int> {4, 5, 6},
                new List<int> {7, 8, 9}
            };

            Console.WriteLine(Summarize(matrix));
            Console.ReadKey();
        }

        static int Summarize(List<List<int>> matrix)
        {
            int sum = 0;
            foreach(var line in matrix)
            {
                foreach(var number in line)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
