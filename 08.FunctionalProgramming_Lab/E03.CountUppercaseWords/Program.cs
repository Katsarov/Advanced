﻿using System;
using System.Linq;

namespace E03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upperChecker = s => s[0] == s.ToUpper()[0];
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(upperChecker).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
