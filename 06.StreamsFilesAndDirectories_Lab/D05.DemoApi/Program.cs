using System;
using System.IO;

namespace D05.DemoApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("../../../demo.txt"));
            File.WriteAllText("../../../demo.txt", "Tova e teksta!!");
        }
    }
}
