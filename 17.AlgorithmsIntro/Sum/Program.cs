using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 9 };

            Console.WriteLine(Sum(array, 0));
        }

        private static int Sum(int[] array, int index)
        {
            if (index == array.Length)
            {
                return 0;
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}
