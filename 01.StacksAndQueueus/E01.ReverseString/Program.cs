using System;
using System.Collections.Generic;

namespace E01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    stack.Push(input[i]);
            //}

            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();

        }
    }
}
