using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravalledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravalledDistance { get; set; }


        public void Drive(int amountOfKm)
        {
            double neededLiters = FuelConsumptionPerKilometer * amountOfKm;
            bool canMove = FuelAmount - neededLiters >= 0;
            if (canMove)
            {
                FuelAmount -= neededLiters;
                TravalledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
