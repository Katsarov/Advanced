using System;
using System.Linq;

namespace E01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            // Прочитаме информацията
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Прочитаме си реда с всички числа 
                var rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Вкарваме всеки един елемент в матрицата - инфото от [текущия ред, текущата колона] е равен на rowData от текущата колона
                    matrix[row, col] = rowData[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            Console.WriteLine(SumMatrix(matrix));

        }

        static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
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
