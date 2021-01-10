using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lamborgini", "Huricane", 2);
            Engine engine = new Engine(650, 1000);
            Tire[] tires = new Tire[]
            {
                new Tire(2008, 1200),
                new Tire(2008, 1200),
                new Tire(2008, 1200),
                new Tire(2008, 1200),
            };
            Car golf = new Car();
            Car toyota = new Car("Corolla", "Caravane", 3, 5, 4, engine, tires);

            car.FuelConsumption = 12;
            car.FuelQuantity = 200;

            car.Drive(20);
            car.Drive(10);

            Console.WriteLine(car.WhoAmI());

            //Console.WriteLine(string.Join(Environment.NewLine, $"Make :{car.Make}", $"Model :{car.Model}", $"Year :{car.Year}"));

            //Console.WriteLine($"{car.Make} - {car.Model} - {car.Year}");
            //Console.WriteLine(car.Make);
            //Console.WriteLine(golf.Make);
            //Console.WriteLine($"{toyota.Make} - {toyota.Model} - {toyota.FuelConsumption}");
        }


    }
}
