using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace D01.Demo_StacksRules
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string book = Console.ReadLine();
            while (book != "end")
            {
                stack.Push(book);


                book = Console.ReadLine();
            }

            string[] arr = stack.ToArray();


            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(stack.Count);
        }
    }
}
