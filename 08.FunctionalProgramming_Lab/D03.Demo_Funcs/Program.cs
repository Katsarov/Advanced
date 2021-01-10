using System;
using System.IO;

namespace D03.Demo_Funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumDelegate = SumNumbers;
            Func<int, int, int> multuplyDelegate = MultuplyNumbers;


            Calculate(5, 5, sumDelegate);
            Calculate(5, 5, multuplyDelegate);
            Calculate(8, 4, (a, b) => a / b);
            Calculate(3, 5, (a, b) => a * 50 + b * 100);

            Calculate(3, 6, sumDelegate);


        }

        static int SumNumbers(int num1, int num2)
        {
            //Console.WriteLine("Summing two numbers is the best feeling.");
            return num1 + num2;
        }

        static int MultuplyNumbers(int num1, int num2)
        {
            Console.WriteLine("Multiplying numbers is the worst feeling.");
            return num1 * num2;
        }

        static void Calculate(int a, int b, Func<int, int, int> operation)
        {
            using (StreamWriter writer = new StreamWriter("../../../result.txt", true))
            {
                writer.WriteLine("Start calculating");
                writer.WriteLine(operation(a, b));
            }
        }
    }
}
