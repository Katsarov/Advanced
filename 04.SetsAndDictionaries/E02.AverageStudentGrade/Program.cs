using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E02.AverageStudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] currentStudents = Console.ReadLine().Split();
                string name = currentStudents[0];
                decimal grade = decimal.Parse(currentStudents[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var item in students)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    allGrades.Append($"{item.Value[i]:f2} ");
                }
                Console.WriteLine($"{item.Key} -> {allGrades.ToString()}(avg: {item.Value.Average():f2})");
            }
        }
    }
}
