using System;
using System.Collections.Generic;

namespace D02.SortedSet_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sorted = new SortedSet<int>();

            sorted.Add(3);
            sorted.Add(17);
            sorted.Add(-2);
            sorted.Add(44);
            sorted.Add(357);
            sorted.Add(22);

            Console.WriteLine(string.Join(Environment.NewLine, sorted));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
