using System;
using System.Linq;

namespace E02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix);
            //PrintMatrix(matrix);

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    // Вземаме си настоящия елемент
                    char currentElement = matrix[row, col];
                    if (currentElement == matrix[row, col + 1] 
                        && currentElement == matrix[row + 1, col + 1]
                        && currentElement == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static void PrintMatrix(char[,] matrix)
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

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
