using System;
using System.Linq;

namespace E02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = ReadMatrix(rows, cols);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumCol += matrix[row, col];
                }

                Console.WriteLine(sumCol);
            }

        }

        // Метод за четене на елементите на матрицата
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
