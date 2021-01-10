using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nums[0];
            int m = nums[1];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);  
            }

            for (int j = 0; j < m; j++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            var intersection = firstSet.Intersect(secondSet);
            //var intersection = firstSet.Union(secondSet);
            Console.WriteLine(string.Join(" ", intersection));

        }
    }
}
