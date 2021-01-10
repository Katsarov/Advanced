using System;

namespace D01.Demo_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 }
            };

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
