using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenCount = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int count = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }

                else
                {
                    for (int i = 0; i < greenCount; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        count++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
