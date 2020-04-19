using System.Collections.Generic;

namespace GradeBook2
{

    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades;

    }
}