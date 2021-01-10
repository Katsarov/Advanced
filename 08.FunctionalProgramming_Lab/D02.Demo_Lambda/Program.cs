using System;
using System.Linq;

namespace D02.Demo_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            var sorted = numbers.Where(CheckEven).ToArray();

            Console.WriteLine(string.Join(" ", sorted));
        }

        static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
