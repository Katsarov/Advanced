using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBox = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondBox = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> firstBoxQueue = new Queue<int>(firstBox);
            Stack<int> secondBoxStack = new Stack<int>(secondBox);

            var claimedItems = new List<int>();

            while (firstBoxQueue.Any() && secondBoxStack.Any())
            {
                int firstBoxItem = firstBoxQueue.Peek();
                int secondBoxItem = secondBoxStack.Peek();

                int itemSum = firstBoxItem + secondBoxItem;

                if (itemSum % 2 == 0)
                {
                    claimedItems.Add(itemSum);
                    firstBoxQueue.Dequeue();
                    secondBoxStack.Pop();
                }
                else
                {
                    secondBoxStack.Pop();
                    firstBoxItem.Equals(secondBoxItem);
                }
            }

            if (!firstBoxQueue.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (!secondBoxStack.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int claimedItemsSum = claimedItems.Sum();

            if (claimedItemsSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItemsSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItemsSum}");
            }

            //Console.WriteLine(claimedItemsSum >= 100 ?
            //    $"Your loot was epic! Value: {claimedItemsSum}" : 
            //    $"Your loot was poor... Value: {claimedItemsSum}");
        }
    }
}
