using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();

            string pattern = @"([=\/])(?<dest>[A-Z][A-Za-z]{2,})\1";



            Regex regex = new Regex(pattern);

            var matches = regex.Matches(places);

            int points = 0;
            var visited = new List<string>();
            foreach (Match item in matches)
            {
                string dest = item.Groups["dest"].Value;
                int len = dest.Length;

                points += len;
                visited.Add(dest);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", visited)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
