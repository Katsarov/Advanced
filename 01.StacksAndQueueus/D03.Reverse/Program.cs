using System;
using System.Collections.Generic;
using System.Linq;

namespace D03.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();

            books.Push("Vinetu");
            books.Push("Die hard");
            books.Push("Matrix");
            books.Push("Otelo");

            Console.WriteLine(books.Count());
            Stack<string> reversed = new Stack<string>(books);

            while (reversed.Count > 0)
            {
                Console.WriteLine(reversed.Pop());
            }

            //Stack<int> nums = new Stack<int>();
            //nums.Push(1);
            //nums.Push(2);
            //nums.Push(3);

            //while (nums.Count > 0)
            //{
            //    Console.Write(nums.Pop() + " ");
            //}
            //Console.WriteLine();

        }
    }
}
