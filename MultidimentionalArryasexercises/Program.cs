using System;

namespace MultidimentionalArryasexercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[n, n];
            ReadMatrix(n, chessBoard);

            int countReplaced = 0;
            int rowKiller = 0;
            int colKIller = 0;
            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int countAttacks = 0;
                        countAttacks = GetAttacs(chessBoard, row, col, currentSymbol, countAttacks);
                        if (countAttacks > maxAttacks)
                        {
                            maxAttacks = countAttacks;
                            rowKiller = row;
                            colKIller = col;
                        }

                    }
                }
                if (maxAttacks > 0)
                {
                    chessBoard[rowKiller, colKIller] = '0';
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }

            
        }

        private static int GetAttacs(char[,] chessBoard, int row, int col, char currentSymbol, int countAttacks)
        {
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                {
                    countAttacks++;
                }
            }
            if (currentSymbol == 'K')
            {
                if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                {
                    countAttacks++;
                }
            }

            return countAttacks;
        }

        private static void PrintMatrix(int n, char[,] chessBoard)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(chessBoard[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int n, char[,] chessBoard)
        {
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = currentRow[col];

                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0)
                && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
        }
    }
}
