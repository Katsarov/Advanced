using System;
using System.Collections.Generic;
using System.Linq;

namespace E108.BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<char> queue = new Queue<char>(input);

            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            int count = 0;
            while (queue.Any())
            {
                char first = queue.Dequeue();
                char next = queue.Peek();

                if (first == '{')
                {
                    if (next == '}')
                    {
                        queue.Dequeue();
                        count = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }

                else if (first == '[')
                {
                    if (next == ']')
                    {
                        queue.Dequeue();
                        count = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }

                else if (first == '(')
                {
                    if (next == ')')
                    {
                        queue.Dequeue();
                        count = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }

                else
                {
                    queue.Enqueue(first);
                }
                count++;

                if (count == queue.Count)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
