using System;
using System.Linq;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] curCommand = command.Split(":");

                if (curCommand.Contains("Add Stop"))
                {
                    int index = int.Parse(curCommand[1]);
                    string curString = curCommand[2];

                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, curString);
                    }
                }

                if (curCommand.Contains("Remove Stop"))
                {
                    int startIndex = int.Parse(curCommand[1]);
                    int endIndex = int.Parse(curCommand[2]);
                    int count = endIndex - startIndex+1;

                    if ((startIndex >=0 && startIndex < input.Length) && (endIndex >= 0 && endIndex < input.Length) && startIndex <= endIndex)
                    {
                        input = input.Remove(startIndex, count);
                    }
                }

                if (curCommand.Contains("Switch"))
                {
                    string oldString = curCommand[1];
                    string newString = curCommand[2];

                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                    }
                }
                Console.WriteLine(input);

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
