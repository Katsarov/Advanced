using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> studentsList;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.studentsList = new List<Student>();
        }

        public int Capacity { get; set; }


        public int Count
        {
            get => this.studentsList.Count;

        }

        public string RegisterStudent(Student student)
        {
            if (this.Capacity > this.Count)
            {
                studentsList.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = studentsList.Find(s => s.FirstName == firstName && s.LastName == lastName);
            if (student != null)
            {
                studentsList.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");

            var studentListnew = studentsList.Where(m => m.Subject == subject).ToList();
            if (studentListnew.Count > 0)
            {
                foreach(var student in studentListnew)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().Trim();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return studentsList.Count();
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.studentsList.FirstOrDefault(n => n.FirstName == firstName && n.LastName == lastName);
            return student;
        }
    }
}
