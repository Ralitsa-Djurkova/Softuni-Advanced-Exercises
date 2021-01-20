using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            ReadMatrix(matrix);

            int sumD1 = 0;
            int sumd2 = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    
                    if(row == col)
                    {
                        sumD1 += matrix[row, col]; ;
                    }

                    if(col == n - 1 - row)
                    {
                        sumd2 += matrix[row, col]; ;
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumD1 - sumd2));
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];

                }

            }
        }

    }
}
