using System;
using System.Collections.Generic;

namespace E06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split(", ");
                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    carPlates.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    carPlates.Remove(carNumber);
                }

                command = Console.ReadLine();
            }

            if (carPlates.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var car in carPlates)
            {
                Console.WriteLine(car);
            }
        }
    }
}
