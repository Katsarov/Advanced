using System;

namespace E07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            // В началото колоните са 1, и при всяка итерация ще ги увеличаваме с 1.
            int cols = 1;

            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[cols];
                pascal[row][0] = 1;  //  Нулевата колона е винаги = 1.
                pascal[row][pascal[row].Length - 1] = 1; // Последния елемент на всеки ред също е = 1.

                // Нашият алгоритъм започва от третия ред (0 1 2). Затова проверката е row > 1
                if (row > 1)
                {
                    for (int col = 1; col < pascal[row].Length - 1; col++)
                    {
                        long[] previousRow = pascal[row - 1];  // вземаме горния ред
                        long firstNum = previousRow[col];  // Вземаме елемента от текущата колона на горния ред
                        long secondNum = previousRow[col - 1];
                        pascal[row][col] = firstNum + secondNum;

                    }
                }
                cols++;
            }

            // Сега го принтираме
            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
