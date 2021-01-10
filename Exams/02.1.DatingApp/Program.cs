using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._1.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> male = new Stack<int>(targets1);

            int[] targets2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> female = new Queue<int>(targets2);

            int matchesCount = 0;

            while (male.Any() && female.Any())
            {
                int currentMales = male.Peek();
                int currentFemales = female.Peek();

                if (currentFemales <= 0)
                {
                    female.Dequeue();
                    continue;
                }

                if (currentMales <= 0)
                {
                    male.Pop();
                    continue;
                }

                if (currentMales % 25 == 0)
                {
                    male.Pop();
                    male.Pop();
                    continue;
                }

                if (currentFemales % 25 == 0)
                {
                    female.Dequeue();
                    female.Dequeue();
                    continue;
                }

                if (currentFemales == currentMales)
                {
                    matchesCount++;
                    male.Pop();
                    female.Dequeue();
                }
                else
                {
                    female.Dequeue();
                    male.Push(male.Pop() - 2);
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            if (male.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ", male)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (female.Any())
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
