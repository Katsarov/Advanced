using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.SetsOfElements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> one = new HashSet<int>();
            HashSet<int> two = new HashSet<int>();

            int[] length = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = length[0];
            int m = length[1];

            for (int i = 0; i < n + m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    one.Add(number);
                }
                else
                {
                    two.Add(number);
                }
            }

            foreach (var number in one)
            {
                if (two.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
                Console.WriteLine();
        }
    }
}
