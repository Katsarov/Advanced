﻿using System;
using System.Collections.Generic;

namespace E04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }

                if (expression[i] == ')')
                {
                    int start = stack.Pop();
                    string content = expression.Substring(start, i - start + 1);
                    Console.WriteLine(content);
                }
            }
        }
    }
}
