using System;
using System.ComponentModel.DataAnnotations;
using CarManufacturer;

namespace D07.BMWManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManufacturer.Engine car = new Engine(100, 350);

            Console.WriteLine($"{car.HorsePower} - {car.CubicCapacity}");
        }
    }
}
