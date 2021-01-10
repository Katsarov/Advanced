using System;
using System.Linq;

namespace E01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            //numbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
