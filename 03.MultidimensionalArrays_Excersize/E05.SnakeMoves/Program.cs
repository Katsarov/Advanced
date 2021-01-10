using System;
using System.Linq;

namespace E05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows, cols];
            var snake = Console.ReadLine();

            for (int i = 0; i < snake.Length; i++)
            {
                char myChar = snake[i];




            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //var snake = Console.ReadLine().ToString();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = snake[myChar];
                }
            }


            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
