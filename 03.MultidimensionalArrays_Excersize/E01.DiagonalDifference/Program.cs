﻿using System;
using System.Linq;

namespace E01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];

            FillMatrix(numbers);
            //PrintMatrix(numbers);

            int sumD1 = 0;
            int sumD2 = 0;

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    int number = numbers[row, col];

                    if (row == col)
                    {
                        sumD1 += number;
                    }

                    if (col == numbers.GetLength(1) -1 - row)
                    {
                        sumD2 += number;
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumD1 - sumD2));
        }

        private static void PrintMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
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
