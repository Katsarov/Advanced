using System;
using System.Collections.Generic;
using System.Text;

namespace D01.Demo
{
    class Cat
    {

        private string name;
        private int age;
        private string color;

        //public string Name { get; set; }

        //public int Age { get; set; }

        //public string Color { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3)
                {
                    return;
                }
                this.name = value;
            }
        }
    }
}
