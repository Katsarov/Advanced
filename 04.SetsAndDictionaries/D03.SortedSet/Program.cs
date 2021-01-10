using System;
using System.Collections.Generic;

namespace D03.SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();
            int num = int.Parse(Console.ReadLine());

            while (num != -1)
            {
                numbers.Add(num);

                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
