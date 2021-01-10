using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.PeriodicTable_Sanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }

            }

            var sorted = elements.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
