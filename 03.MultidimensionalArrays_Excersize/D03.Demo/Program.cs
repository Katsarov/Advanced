using System;

namespace D03.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToString();
            Console.WriteLine(string.Join(' ', name));
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine();


            foreach (var item in name)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
