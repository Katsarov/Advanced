using System;

namespace D01.DemoFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hopa");
            //}

            void Loop(int n)
            {
                if (n == 10) return;
                Console.WriteLine("Hop");
                Loop(n + 1);
            }
            Loop(0);
        }
    }
}
