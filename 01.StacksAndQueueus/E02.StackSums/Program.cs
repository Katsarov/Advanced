using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.StackSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                var tokens = command.Split().ToArray();

                if (tokens[0] == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (tokens[0] == "remove")
                {
                    int count = int.Parse(tokens[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }

                command = Console.ReadLine().ToLower();
            }

            //int sum = 0;
            //while (stack.Count> 0)
            //{
            //    sum += stack.Pop();
            //}

            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
