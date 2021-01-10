using System;

namespace D02.Demo_Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7, 9];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    //array[row, col] = row + col;
                    Console.Write(array[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
