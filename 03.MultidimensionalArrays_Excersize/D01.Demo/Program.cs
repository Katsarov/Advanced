using System;
using System.Linq;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 7];
            FillMatrix(numbers);
            PrintMatrix(numbers);
        }

        private static void PrintMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
            }
        }

        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currentRow[col];
                }
            }
        }
    }
}
