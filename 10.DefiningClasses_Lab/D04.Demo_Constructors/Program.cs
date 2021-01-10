using System;

namespace D04.Demo_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human("Pesho", 15);
            Human human = new Human("Pesho");

            //Console.WriteLine($"{human.Name} - {human.Age}");
            Console.WriteLine(human.Name);

            human.Eat();
            human.Die();
            human.Eat();

        }
    }
}
