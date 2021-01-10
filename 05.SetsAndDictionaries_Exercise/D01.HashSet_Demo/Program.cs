using System;
using System.Collections.Generic;
using System.Linq;

namespace D01.HashSet_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            first.Add(2);
            first.Add(7);
            first.Add(15);
            second.Add(15);
            second.Add(4);
            second.Add(100);
            second.Add(-12);

            var united = first.Union(second);
            Console.WriteLine(string.Join(" ", united));
        }
    }
}
