using System;
using System.Collections.Generic;
using System.Text;

namespace D06.Demo_StaticClasses
{
    static class BankHelpers
    {
        public static string Name { get; set; }

        public static void CalculateDebt(double income)
        {
            Console.WriteLine("Mnogo dulg!");
        }
    }
}
