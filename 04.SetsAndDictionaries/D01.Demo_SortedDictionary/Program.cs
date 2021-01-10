using System;
using System.Collections.Generic;

namespace D01.Demo_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Правим си едно дикшънъри от студенти с оценки
            SortedDictionary<string, int> grades = new SortedDictionary<string, int>();

            grades.Add("Dimitrichko", 6);
            grades.Add("Niki", 2);
            grades.Add("Drug", 6);
            grades.Add("Viktor", 3);

            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
