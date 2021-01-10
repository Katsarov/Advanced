using System;

namespace D05.Demo_Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = Payment.GoToCanada;
            //Console.WriteLine(payment);
            //DoPayment(Payment.GoToCanada);
            //DoPayment(Payment.Cash);
            DoPayment(Payment.Terminal);
        }

        static void DoPayment(Payment type)
        {
            if (type == Payment.Cash)
            {
                Console.WriteLine("Take all the money");
            }
            if (type == Payment.GoToCanada)
            {
                Console.WriteLine("Forget the money");
            }
            else
            {
                Console.WriteLine(type);
            }
        }
    }
}
