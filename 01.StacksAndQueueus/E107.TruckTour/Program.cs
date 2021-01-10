using System;
using System.Collections.Generic;
using System.Linq;

namespace E107.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int truckPumps = int.Parse(Console.ReadLine());

            Queue<string> circle = new Queue<string>();

            for (int i = 0; i < truckPumps; i++)
            {
                string input = Console.ReadLine();
                // За да запазим оригиналния индекс на настоящата помпа
                input += $" {i}";
                circle.Enqueue(input);
            }

            int totalFuel = 0;
            for (int i = 0; i < truckPumps; i++)
            {
                string currentInfo = circle.Dequeue();
                var info = currentInfo.Split().Select(int.Parse).ToArray();

                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }

                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                circle.Enqueue(currentInfo);
            }

            var firstElement = circle.Dequeue().Split().ToArray();
            Console.WriteLine(firstElement[2]);
        }
    }
}
