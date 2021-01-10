using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Asus");
            //Console.WriteLine(laptop.Name);
            laptop.Print();

            Laptop laptop2 = new Laptop("AsusTiger");
            //Console.WriteLine(laptop.Name);
            laptop2.Print();
        }
    }
}

// Да създадем нчкакъв клас. Този клас трябва да има:
// конструктор
// пропърти
// поле
// метод

// Накрая да си направим един обект