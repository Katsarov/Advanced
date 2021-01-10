using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace D03.Demo_Students
{
    public class Student
    {
        private int age;



        public int Age
        {
            get 
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                if (value > 100)
                {
                    throw new ArgumentException("Too old, sorry!");
                }

                age = value;
            }
        }
    }
}
