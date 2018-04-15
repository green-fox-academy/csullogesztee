using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        //Create a function that takes a matrix(list of lists)
        //    of numbers and returns the sum of each rows as an array
        static void Main(string[] args)
        {
            List<List<int>> MyMatrix = new List<List<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {1, 2, 3},
                new List<int> {1, 2, 3}
            };

            MethodsOfMatrix.Printer(MethodsOfMatrix.RowsOfTheMatrix(MyMatrix));
            Console.ReadLine();
        }
    }

    public class MethodsOfMatrix
    {
        public static int[] RowsOfTheMatrix(List<List<int>> matrix)
        {
            List<int> SumOfTheRows = new List<int>();
            foreach (var row in matrix)
            {
                SumOfTheRows.Add(SumOfNumbers(row));
            }

            return SumOfTheRows.ToArray();
        }

        public static int SumOfNumbers(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static void Printer(int[] resultArray)
        {
            foreach (int element in resultArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}

