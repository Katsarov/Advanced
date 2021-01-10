using System;
using System.Text.RegularExpressions;

namespace _02.DestinationManager_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();

            string pattern = @"(=|\/)(?<destination>[A-Za-z]{2,})\1";
            //string pattern = @"([=\/])([A-Z][a-z]{2,})(\1)";



            Regex regex = new Regex(pattern);

            var matches = regex.Matches(places);

            int points = 0;
            string visited = String.Empty;
            foreach (Match item in matches)
            {
                string gr1 = item.Groups[1].Value;
                string gr2 = item.Groups[2].Value;
                string gr3 = item.Groups[3].Value;

                for (int i = 0; i < gr2.Length; i++)
                {
                    points++;
                }

                visited += gr2 + ", ";

            }
            Console.WriteLine($"Destinations: {string.Join(", ", visited)}");
            Console.WriteLine($"Travel Points: {points}");

        }
    }
}
