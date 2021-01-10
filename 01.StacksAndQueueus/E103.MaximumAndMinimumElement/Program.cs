using System;
using System.Collections.Generic;
using System.Linq;

namespace E103.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "1")
                {
                    stack.Push(input[1]);
                }

                if (input[0] == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }

                if (input[0] == "3")
                {
                    string maxElement = stack.Max();
                    Console.WriteLine(maxElement);
                }
                if (input[0] == "4")
                {
                    string minElement = stack.Min();
                    Console.WriteLine(minElement);
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
