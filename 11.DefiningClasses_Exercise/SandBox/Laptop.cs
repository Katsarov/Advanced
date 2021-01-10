using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox
{
    public class Laptop
    {
        private string name;

        public Laptop(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
