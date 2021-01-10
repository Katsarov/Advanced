using System;
using System.Linq;

namespace E04.MatrixShuffling
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

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "swap")
                {
                    int row1Coordinates = int.Parse(tokens[1]);
                    int col1Coordinates = int.Parse(tokens[2]);
                    int row2Coordinates = int.Parse(tokens[3]);
                    int col2Coordinates = int.Parse(tokens[4]);

                    string firstElement = matrix[row1Coordinates, col1Coordinates];
                    string secondElement = matrix[row2Coordinates, col2Coordinates];

                    if ((row1Coordinates < 0 || row1Coordinates >= matrix.GetLength(0))
                        || (col1Coordinates < 0 || col1Coordinates >= matrix.GetLength(1))
                        || (row2Coordinates < 0 || row2Coordinates >= matrix.GetLength(0))
                        || (col1Coordinates < 0 || col1Coordinates >= matrix.GetLength(1)))
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (row == row1Coordinates && col == col1Coordinates)
                                {
                                    matrix[row, col] = secondElement;
                                }

                                else if (row == row2Coordinates && col == col2Coordinates)
                                {
                                    matrix[row, col] = firstElement;
                                }
                            }
                        }

                        //for (int row = 0; row < matrix.GetLength(0); row++)
                        //{
                        //    for (int col = 0; col < matrix.GetLength(1); col++)
                        //    {
                        //        if (matrix[row1Coordinates,col1Coordinates] == matrix[row,col])
                        //        {
                        //            string temp = matrix[row1Coordinates, col1Coordinates];
                        //            matrix[row1Coordinates, col1Coordinates] = matrix[row2Coordinates, col2Coordinates];
                        //            matrix[row2Coordinates, col2Coordinates] = temp;
                        //        }
                        //    }
                        //}

                        PrintMatrix(matrix);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                //PrintMatrix(matrix);
                command = Console.ReadLine();
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
