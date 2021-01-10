using System;
using System.Collections.Generic;

namespace D02.QueueRules
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Noah");
            queue.Enqueue("Jacob");
            queue.Enqueue("Peter");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
