using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.Wordrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ").ToArray();  // Blue -> dress,jeans,hat
                var color = input[0];
                var clothes = input[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }

            var clothingToFind = Console.ReadLine().Split(" ").ToArray();  // Blue dress

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var dress in color.Value)
                {
                    Console.Write($"* {dress.Key} - {dress.Value} ");
                    if (dress.Key == clothingToFind[1] && color.Key == clothingToFind[0])
                    {
                        Console.Write("(found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
