using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_01.FlowersWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var roses = Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var lillies = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            Stack<int> lilliesStack = new Stack<int>(lillies);
            Queue<int> rosesQueue = new Queue<int>(roses);

            int wreathCounter = 0;
            int storedFlowers = 0;

            while (lilliesStack.Count > 0 && rosesQueue.Count > 0)
            {
                int sum = lilliesStack.Peek() + rosesQueue.Peek();
                if (sum == 15)
                {
                    lilliesStack.Pop();
                    rosesQueue.Dequeue();
                    wreathCounter++;
                }

                else if (sum > 15)
                {
                    int lilliesValue = lilliesStack.Pop();
                    lilliesStack.Push(lilliesValue - 2);
                }

                else
                {
                    storedFlowers += lilliesStack.Pop() + rosesQueue.Dequeue();
                }
            }

            wreathCounter += storedFlowers / 15;

            if (wreathCounter >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCounter} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCounter} wreaths more!");
            }
        }
    }
}
