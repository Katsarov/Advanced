using System;
using System.Linq;

namespace E03.MaximalSum_Kalin

{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int rows = input[0];
                int cols = input[1];

                int[,] matrix = new int[rows, cols];
                FillMatrix(matrix);

                //int count = 0;
                int sum = int.MinValue;
                int firstMaxRow = 0;
                int firstMaxCol = 0;

                for (int row = 0; row < rows - 2; row++)
                {
                    for (int col = 0; col < cols - 2; col++)
                    {
                        int curElement = matrix[row, col];
                        int firstRowSecond = matrix[row, col + 1];
                        int firstRowThird = matrix[row, col + 2];
                        int secondFirst = matrix[row + 1, col];
                        int secondSecond = matrix[row + 1, col + 1];
                        int secondThird = matrix[row + 1, col + 2];
                        int thirddFirst = matrix[row + 2, col];
                        int thirdSecond = matrix[row + 2, col + 1];
                        int thirdThird = matrix[row + 2, col + 2];
                        int total = curElement + firstRowSecond + firstRowThird + secondFirst + secondSecond + secondThird + thirddFirst + thirdSecond + thirdThird;
                        if (total > sum)
                        {
                            sum = total;
                            firstMaxRow = row;
                            firstMaxCol = col;

                        }
                    }
                }

                Console.WriteLine($"Sum = {sum}");
                PrintMatrix(matrix, firstMaxRow, firstMaxCol);
            }

            static void PrintMatrix(int[,] matrix, int firstMaxRow, int firstMaxCol)
            {
                for (int row = firstMaxRow; row < firstMaxRow + 3; row++)
                {
                    for (int col = firstMaxCol; col < firstMaxCol + 3; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }

            static void FillMatrix(int[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = rowData[col];
                    }
                }
            }
        }
    }
}
