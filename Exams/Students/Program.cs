using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> topStudents = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                topStudents.Add(new Student());
            }

            //topStudents = topStudents.OrderBy(s => s.Grade).ToList();

            topStudents.Sort(new StudentsComparer());

            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }
        }
    }
}
