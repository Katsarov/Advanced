using System;
using System.Collections.Generic;
using System.Linq;

namespace Sheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Stack<int> tasksStack = new Stack<int>(tasks);
            List<int> threads = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> threadsQueue = new Queue<int>(threads);

            var taskToBeKilled = int.Parse(Console.ReadLine());

            while (threadsQueue.Any() && tasksStack.Any())
            {
                int currThread = threadsQueue.Peek();
                int currTask = tasksStack.Peek();

                if (currTask == taskToBeKilled)
                {
                    Console.WriteLine($"Thread with value {currThread} killed task {taskToBeKilled}");
                    Console.WriteLine(string.Join(" ", threadsQueue));
                    break;
                }

                if (currThread >= currTask)
                {
                    threadsQueue.Dequeue();
                    tasksStack.Pop();
                }
                else if (currThread < currTask)
                {
                    threadsQueue.Dequeue();
                }
            }
        }
    }
}
