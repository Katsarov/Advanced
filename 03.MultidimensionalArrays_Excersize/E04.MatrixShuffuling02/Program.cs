﻿using System;
using System.Linq;

namespace E04.MatrixShuffuling02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (!ValidateCommand(command, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string[] commands = command.Split();
                int rowIndexFirst = int.Parse(commands[1]);
                int colIndexFirst = int.Parse(commands[2]);
                int rowIndexSecond = int.Parse(commands[3]);
                int colIndexSecond = int.Parse(commands[4]);

                string firstElement = matrix[rowIndexFirst, colIndexFirst];
                string secondElement = matrix[rowIndexSecond, colIndexSecond];

                matrix[rowIndexFirst, colIndexFirst] = secondElement;
                matrix[rowIndexSecond, colIndexSecond] = firstElement;

                PrintMatrix(matrix);

            }
        }

        private static bool ValidateCommand(string command, int rows, int cols)
        {
            string[] commands = command.Split();
            if (commands.Length == 5 && commands[0] == "swap"
                && int.Parse(commands[1]) <= rows
                && int.Parse(commands[2]) <= cols
                && int.Parse(commands[3]) <= rows
                && int.Parse(commands[4]) <= cols)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrintMatrix(string[,] matrix)
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

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
