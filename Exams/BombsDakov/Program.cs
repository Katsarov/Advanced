using System;
using System.Collections.Generic;
using System.Linq;

namespace BombsDakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToList());
            Stack<int> casing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToList());

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            int decrease = 0;

            while (effects.Count > 0 && casing.Count > 0)
            {
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    break;
                }

                int currentEffects = effects.Peek();
                int currentCasing = casing.Peek() - decrease;
                int combined = currentEffects + currentCasing;
                bool bombCreated = false;

                if (combined == 40)
                {
                    datura++;
                    bombCreated = true;
                }
                else if (combined == 60)
                {
                    cherry++;
                    bombCreated = true;
                }
                else if (combined == 120)
                {
                    smoke++;
                    bombCreated = true;
                }

                if (bombCreated)
                {
                    effects.Dequeue();
                    casing.Pop();
                    decrease = 0;
                }

                else if (currentCasing <= 0)
                {
                    casing.Pop();
                    decrease = 0;
                }

                else
                {
                    decrease += 5;
                }
            }

            if (datura >= 3 && cherry >= 3 && smoke >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }

            if (casing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }

            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            dict.Add("Datura Bombs", datura);
            dict.Add("Cherry Bombs", cherry);
            dict.Add("Smoke Decoy Bombs", smoke);

            foreach (var bomb in dict)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
