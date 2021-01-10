using System;
using System.Collections.Generic;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> info = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                string[] action = command.Split("<->");

            }





            while (command != "Exhibition")
            {
                string[] action = command.Split(":");

                if (action[0].Contains("Rate"))
                {
                    string[] tokens = action[0].Split("<->");

                    int plant = int.Parse(tokens[0]);

                }


                command = Console.ReadLine();
            }
        }
    }
}
