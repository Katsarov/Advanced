using System;

namespace D02.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharoDog = new Dog();
            sharoDog.Name = "Sharo";
            sharoDog.Years = 7;
            Console.WriteLine(sharoDog.Name);

            Dog peshoDog = new Dog();
            peshoDog.Name = "Pesho";
            Console.WriteLine(peshoDog.Name);

            peshoDog = sharoDog;
            Console.WriteLine(peshoDog.Name);

        }
    }
}
