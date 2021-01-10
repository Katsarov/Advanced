using System;

namespace _02._2.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            var player = new Player(0, 0);
            ReadMatrix(n, player, matrix);

            string command = Console.ReadLine();
            while (command != "end")
            {
                var curRow = player.Row;
                var curCol = player.Col;
                SwitchInput(command, ref curRow, ref curCol);

                if (ValidateNewPosition(curRow, curCol, matrix))
                {
                    matrix[player.Row, player.Col] = '-';
                    if (char.IsLetter(matrix[curRow, curCol]))
                    {
                        if (str.Length > 0)
                        {
                            str += matrix[curRow, curCol];
                            matrix[curRow, curCol] = 'P';
                        }                       
                    }
                    player.Row = curRow;
                    player.Col = curCol;

                }

                else
                {
                    str = str.Remove(str.Length - 1);
                }

                command = Console.ReadLine();
            }

            PrintResult(str, matrix);
        }

        private static bool ValidateNewPosition(int row, int col, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col <= matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void SwitchInput(string command, ref int curRow, ref int curCol)
        {
            switch (command)
            {
                case "up":
                    curRow--;
                    break;

                case "down":
                    curRow++;
                    break;

                case "left":
                    curCol--;
                    break;

                case "right":
                    curCol++;
                    break;

                default:
                    break;
            }
        }

        private static void ReadMatrix(int n, Player player, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                    if (row[j] == 'P')
                    {
                        player.Row = i;
                        player.Col = j;
                    }
                }
            }
        }

        private static void PrintResult(string str, char[,] matrix)
        {
            Console.WriteLine(str);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        
    }
    public class Player
    {
        public Player(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}
