using System;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop(8);
        }

        private static void Loop(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(n);
            Loop(n - 1);
        }
    }
}
