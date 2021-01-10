using System;
using System.Collections.Generic;
using System.Linq;

namespace E105.FassionBoutique_s
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(numbers);

            int rackCounter = 0;
            int sum = 0;

            while (stack.Count > 0)
            {
                var currentCloth = stack.Peek();
                
                if (sum + currentCloth > capacity)
                {
                    rackCounter++;
                    sum = 0;
                }

                else if (sum + currentCloth == capacity)
                {
                    rackCounter++;
                    sum = 0;
                    stack.Pop();
                }

                else
                {
                    sum += stack.Pop();
                }
            }

            if (sum > 0)
            {
                rackCounter++;
            }

            Console.WriteLine(rackCounter);
        }
    }
}
