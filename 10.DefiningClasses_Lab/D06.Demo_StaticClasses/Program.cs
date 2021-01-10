using System;

namespace D06.Demo_StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            BankHelpers.Name = "Tokuda Bank SA";
            BankHelpers.CalculateDebt(55);
        }
    }
}
