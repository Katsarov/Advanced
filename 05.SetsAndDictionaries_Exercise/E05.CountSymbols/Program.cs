using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            var text = Console.ReadLine().ToString();

            for (int i = 0; i < text.Length; i++)
            {
                if (!letters.ContainsKey(text[i]))
                {
                    letters.Add(text[i], 0);
                }
                letters[text[i]]++;
            }

            var sortedLetters = letters.OrderBy(x => x.Key);
            foreach (var letter in sortedLetters)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
