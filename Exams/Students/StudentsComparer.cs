using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Students
{
    class StudentsComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Grade.CompareTo(x.Grade) * -1;
        }
    }
}
