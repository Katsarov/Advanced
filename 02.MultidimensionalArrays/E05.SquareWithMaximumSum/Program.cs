using System;
using System.Linq;

namespace E05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = ReadMatrix(rows, cols);

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            // Да си отпечатаме първо квадратчетата. Да внимаваме да не излезем долу и в дясно!!! Затова четем редовете до matrix.GetLength(0) - 1 и колоните до matrix.GetLength(1) - 1
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    // Посочваме квадратчетата: горе ляво: matrix[row, col], долу в ляво: matrix[row + 1, col], горе в дясно: matrix[row, col + 1] и долу в дясно: matrix[row + 1, col + 1]  
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine(matrix[maxRow, maxCol] + " " + matrix[maxRow, maxCol + 1]);
            Console.WriteLine(matrix[maxRow + 1, maxCol] + " " + matrix[maxRow + 1, maxCol + 1]);

            Console.WriteLine(maxSum);
            //PrintMatrix(matrix);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
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
    }
}
