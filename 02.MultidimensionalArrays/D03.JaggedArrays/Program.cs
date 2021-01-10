using System;
using System.Linq;

namespace D03.JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

                matrix[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            // Изчертаване на матрицата
            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    for (int col = 0; col < matrix[row].Length; col++)
            //    {
            //        Console.Write(matrix[row][col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
