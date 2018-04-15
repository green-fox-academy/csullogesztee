using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        //Create a function that takes a number returns a matrix(list of lists) with height
        //    and width as the number, all of it's elments should be zero, beside the main diagonal
        //    should be ones like:

        //    1 0 0 0 0
        //    0 1 0 0 0
        //    0 0 1 0 0
        //    0 0 0 1 0
        //    0 0 0 0 1
        static void Main(string[] args)
        {
            Console.WriteLine("Add your number!");
            int myNumber = int.Parse(Console.ReadLine());

            MatrixPrinter(MatrixCreator(myNumber));

            Console.ReadKey();
        }

        static List<List<int>> MatrixCreator(int number)
        {
            List<List<int>> matrix = new List<List<int>>();
            for(int i = 0; i < number; i++)
            {
                List<int> newRow = new List<int>();
                for(int j = 0; j < number; j++)
                {
                    if(i == j)
                    {
                        newRow.Add(1);
                    }
                    else
                    {
                        newRow.Add(0);
                    }
                }
                matrix.Add(newRow);
            }
            return matrix;
        }

        static void MatrixPrinter(List<List<int>> matrix)
        {
            foreach(var line in matrix)
            {
                foreach(var number in line)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
