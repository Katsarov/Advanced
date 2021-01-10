using System;
using System.Linq;
using System.Text;

namespace E06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = rowData[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var token = command.Split().ToArray();

                if (token[0] == "Add")
                {
                    int firstToken = int.Parse(token[1]);
                    int secondToken = int.Parse(token[2]);
                    int thirdToken = int.Parse(token[3]);

                    StringBuilder sb = new StringBuilder();

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        int rowPosition
                        
                        if ((firstToken < 0 || firstToken >= matrix.GetLength(0)) || (secondToken < 0 || secondToken >= matrix.GetLength(1)))
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                            
                        }

                        else
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                matrix[col] += thirdToken;
                            }
                        }
                        
                    }
                }

                //if (token[0] == "Substract")
                //{
                //    for (int row = 0; row < matrix.GetLength(0); row++)
                //    {
                //        int firstToken = int.Parse(token[1]);
                //        int secondToken = int.Parse(token[2]);
                //        int thirdToken = int.Parse(token[3]);
                //        if (firstToken >= 0 && firstToken < matrix.Length)
                //        {
                //            for (int col = 0; col < matrix.GetLength(1); col++)
                //            {
                //                if (secondToken >= 0 && secondToken < matrix.Length)
                //                {
                //                    matrix[row, col] -= thirdToken;
                //                }
                //            }
                //        }

                //        else
                //        {
                //            Console.WriteLine("Invalid coordinates");
                //        }

                //    }
                //}

                command = Console.ReadLine();
            }
            PrinMatrix(matrix);

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }

        static void PrinMatrix(int[,] matrix)
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
    }
}
