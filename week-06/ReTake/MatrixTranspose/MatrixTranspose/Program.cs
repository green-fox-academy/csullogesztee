using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a function that takes a matrix (array of arrays) as a parameter and
// returns the transpose of that matrix. The original matrix should remain the
// same.

// For this input:
// [
//     [1, 2, 3],
//     [4, 5, 6],
//     [7, 8, 9]
// ]

// This should be the output:
// [
//     [1, 4, 7],
//     [2, 5, 8],
//     [3, 6, 9]
// ]

namespace MatrixTranspose
{
    public class MatrixTranspose
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
                {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

            ArrayPrinter(Transpose(matrix));
            Console.ReadKey();
        }

        public static int[,] Transpose(int[,] randomMatrix)
        {
            int[,] newMatrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newMatrix[i, j] = randomMatrix[j, i];
                }
            }
            return newMatrix;
        }

        public static void ArrayPrinter(int[,] randomArray)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.Write("[ ");
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(randomArray[i,j] + " ");
                }
                Console.WriteLine("]");
            }
        }
    }
}