﻿using System;
using System.Net.Http.Headers;

namespace DefiningClasses

{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person[] people = family.GetPeople();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
