using System;
using System.Linq;

namespace _06JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] rowData = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                jaggedMatrix[row] = rowData;
            }
            //for (int row = 0; row < n; row++)
            //{
            //    int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //    jaggedMatrix[row] = new int[rowData.Length];
            //    for (int col = 0; col < n; col++)
            //    {
            //        jaggedMatrix[row][col] = rowData[col];


            //    }
            //}

            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArray = jaggedMatrix[row];
                double[] secondArray = jaggedMatrix[row + 1];
                if(firstArray.Length == secondArray.Length)
                {
                    jaggedMatrix[row] = firstArray.Select(e => e * 2).ToArray();
                    jaggedMatrix[row + 1] = secondArray.Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = firstArray.Select(e => e / 2).ToArray();
                    jaggedMatrix[row + 1] = secondArray.Select(x => x / 2).ToArray();
                }
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandData = command.Split(" ");
                int rowIndex = int.Parse(commandData[1]);
                int colIndex = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                if(commandData[0] == "Add")
                {
                    bool isvalidCell = rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < jaggedMatrix[rowIndex].Length;

                    if (!isvalidCell)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    jaggedMatrix[rowIndex][colIndex] += value;
                }
                else if(commandData[0] == "Subtract")
                {
                    bool isvalidCell = rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < jaggedMatrix[rowIndex].Length;

                    if (!isvalidCell)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    jaggedMatrix[rowIndex][colIndex] -= value;
                }
                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ",jaggedMatrix[row]));
            }
        }
    }
}
