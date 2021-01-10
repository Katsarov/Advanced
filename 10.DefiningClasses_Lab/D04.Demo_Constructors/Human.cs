using System;
using System.Collections.Generic;
using System.Text;

namespace D04.Demo_Constructors
{
    class Human
    {
        //field
        private bool isAlive;


        //constructors
        public Human()
        {
            isAlive = true;
        }

        public Human(string name) : this()
        {
            Name = name;
        }

        public Human(string name, int age) : this(name)
        {
            Age = age;
        }


        //property
        public string Name { get; set; }
        public int Age { get; set; }


        //method
        public void Eat()
        {
            if (isAlive)
            {
                Console.WriteLine("I am eating!");
            }
            else
            {
                Console.WriteLine("I can not eating, because I died!");
            }
        }

        public void Die()
        {
            isAlive = false;
        }
    }
}
