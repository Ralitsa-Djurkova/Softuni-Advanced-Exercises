using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            string command = Console.ReadLine();

            while (true)
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] commandData = command.Split(" ");

                if(commandData.Length != 5 || commandData[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                int rowOne = int.Parse(commandData[1]);
                int colOne = int.Parse(commandData[2]);
                int rowTwo = int.Parse(commandData[3]);
                int colTwo = int.Parse(commandData[4]);

                bool isValidOne = rowOne >= 0 && rowOne < rows && colOne >= 0 && colOne < cols;
                bool isValidTwo = rowTwo >= 0 && rowTwo < rows && colTwo >= 0 && colTwo < cols;
                //bool isOutOfMatrix = rowOne < 0 || rowOne > rows || colOne < 0 || colOne > cols;

                if(!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row,col] + " ");
                    }

                    Console.WriteLine();
                }
                
            }
        }
    }
}
