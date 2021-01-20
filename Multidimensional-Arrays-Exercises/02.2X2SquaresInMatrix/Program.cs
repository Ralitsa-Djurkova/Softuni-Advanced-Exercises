using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = numbers[0];
            int cols = numbers[1];

            char[,] matrix = new char[rows, cols];
            ReadMatrix(matrix);
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
               
                for (int col = 0; col < cols - 1; col++)
                {
                    char latter = matrix[row, col];
                    if (latter == matrix[row, col + 1]
                        && latter == matrix[row + 1, col + 1] 
                        && latter == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];

                }

            }
        }
    }
}
