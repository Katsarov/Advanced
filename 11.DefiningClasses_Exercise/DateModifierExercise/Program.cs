﻿using System;
using System.Linq;

namespace DateModifierExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            var result = dateModifier.GetDaysDifference(startDate, endDate);

            Console.WriteLine(Math.Abs(result));
        }
    }
}
