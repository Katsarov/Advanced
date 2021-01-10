using System;
using System.Linq;

namespace E06.JaggedarrayManipulation_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                var rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new int[rowData.Length];
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                var splitted = command.Split();
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                // проверяваме индексите
                if ((row < 0 || row >= matrix.Length) || (col < 0 || col >= matrix[row].Length))
                {
                    Console.WriteLine("Invalid coordinates");
                }

                else
                {
                    if (splitted[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }

                    if (splitted[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
