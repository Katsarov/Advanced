using System;
using System.Collections.Generic;

namespace E07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            
            AddReservations(vipGuests, regularGuests);
            RemoveArrivedGuest(vipGuests, regularGuests);
            
            PrintGuests(vipGuests, regularGuests);
        }

        private static void PrintGuests(HashSet<string> vipGuests, HashSet<string> regularGuests)
        {
            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            if (vipGuests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
            }
            if (regularGuests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
            }
        }

        private static void RemoveArrivedGuest(HashSet<string> vipGuests, HashSet<string> regularGuests)
        {
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "END")
                {
                    break;
                }

                if (char.IsDigit(guest[0]) && vipGuests.Contains(guest))
                {
                    vipGuests.Remove(guest);
                }
                else
                {
                    regularGuests.Remove(guest);
                }
            }
        }

        private static void AddReservations(HashSet<string> vipGuests, HashSet<string> regularGuests)
        {
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(guest[0]))
                {
                    vipGuests.Add(guest);
                }
                else
                {
                    regularGuests.Add(guest);
                }
            }
        }
    }
}
