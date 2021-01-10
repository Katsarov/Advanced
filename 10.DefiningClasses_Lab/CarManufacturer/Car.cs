using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelConsumption = 200;
            FuelQuantity = 10;
        }

        // now we make second constructor which invokes make, model and year
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumption;
            if (FuelQuantity - consumption <= 0)
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= consumption;
            }
        }

        public string WhoAmI()
        {
            //return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
            return string.Join(Environment.NewLine, $"Make: {this.Make}", $"Model: {this.Model}", $"Year: {this.Year}", $"Fuel: {this.FuelQuantity:F2}L");
        }
    }
}
