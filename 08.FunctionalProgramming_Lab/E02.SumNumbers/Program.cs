using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace E02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            //Console.WriteLine(numbers.Count());
            //Console.WriteLine(numbers.Sum());

            int[] array = Console.ReadLine().Split(", ").Select(ParseNumber).ToArray();
            PrintResults(array, GetCount, GetSum);
        }

        static int GetCount(int[] array)
        {
            return array.Count();
        }

        static int GetSum(int[] array)
        {
            return array.Sum();
        }

        static void PrintResults(int[] array, 
            Func<int[], int> count, 
            Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        static int ParseNumber(string number)
        {
            return int.Parse(number);
        }
    }
}
