using System;

namespace Exam_E02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] beeTerritory = new char[n,n];

            int beeRow = -1;
            int beeCol = -1;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    beeTerritory[row, col] = input[col];
                    if (input[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            int pollinatedFlowers = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                beeTerritory[beeRow, beeCol] = '.';
                if (command == "up")
                {
                    beeRow--;
                }

                else if (command == "down")
                {
                    beeRow++;
                }

                else if (command == "left")
                {
                    beeCol--;
                }

                else if (command == "right")
                {
                    beeCol++;
                }

                if (beeCol > n - 1 || beeCol < 0 || beeRow < 0 || beeRow > n - 1)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (beeTerritory[beeRow, beeCol] == 'f')
                {
                    pollinatedFlowers++;
                }

                if (beeTerritory[beeRow, beeCol] == 'O')
                {
                    continue;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                beeTerritory[beeRow, beeCol] = 'B';
            }

            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }

            

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(beeTerritory[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
