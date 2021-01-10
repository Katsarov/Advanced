using System;
using System.Collections.Generic;
using System.Linq;

namespace E104.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodPrepared = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if (foodPrepared >= queue.Peek())
                {
                    foodPrepared -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
