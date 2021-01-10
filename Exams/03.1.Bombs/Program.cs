using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._1.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> bombEffects = new Queue<int>(target1);

            int[] target2 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> bombCasing = new Stack<int>(target2);

            Dictionary<int, int> bombs = new Dictionary<int, int>();
            bombs.Add(40, 0);
            bombs.Add(60, 0);
            bombs.Add(120, 0);

            while (bombEffects.Any() && bombCasing.Any())
            {
                var curResult = bombEffects.Dequeue() + bombCasing.Peek();
                while (curResult > 120 || (curResult > 60 && curResult < 120) || (curResult > 40 && curResult < 60))
                {
                    curResult -= 5;
                }

                if (bombs.Any(b => b.Key == curResult))
                {
                    bombs[curResult]++;
                }

                bombCasing.Pop();

                if (bombs.All(b => b.Value >= 3))
                {
                    break;
                }
            }

            Dictionary<string, Dictionary<int, int>> dict = new Dictionary<string, Dictionary<int, int>>();
            dict.Add("Datura Bombs", bombs.Where(b => b.Key == 40).ToDictionary(b => b.Key, b => b.Value));
            dict.Add("Cherry Bombs", bombs.Where(b => b.Key == 60).ToDictionary(b => b.Key, b => b.Value));
            dict.Add("Smoke Decoy Bombs", bombs.Where(b => b.Key == 120).ToDictionary(b => b.Key, b => b.Value));

            if (bombs.All(b => b.Value >= 3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var bomb in dict.OrderBy(b => b.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value.Values.Sum()}");
            }
        }
    }
}
