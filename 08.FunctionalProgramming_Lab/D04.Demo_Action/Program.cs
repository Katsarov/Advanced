using System;

namespace D04.Demo_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> logger = LogInfo;

            logger("Pesho");
            logger("Dimitrichko");
        }

        static void LogInfo(string name)
        {
            Console.WriteLine($"Say my name {name}!");
        }
    }
}
