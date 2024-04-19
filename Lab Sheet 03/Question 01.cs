using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
          class Course
{
    private string courseName;
    private string instructorName;
    private double grade;

    public string CourseName
    {
        get { return courseName; }
    }

    public double Grade
    {
        get
        {
            if (grade < 0 || grade > 100)
                throw new Exception("Invalid grade");
            return grade;
        }
        private set
        {
            if (value < 0 || value > 100)
                throw new Exception("Invalid grade");
            grade = value;
        }
    }

    public void SetInstructorName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new Exception("Invalid instructor name");
        instructorName = name;
    }

    private string CalculateLetterGrade()
    {
        if (grade >= 90) return "A";
        else if (grade >= 80) return "B";
        else if (grade >= 70) return "C";
        else if (grade >= 60) return "D";
        else return "F";
    }

    public void PrintCourseInfo()
    {
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Instructor Name: {instructorName}");
        Console.WriteLine($"Letter Grade: {CalculateLetterGrade()}");
    }
}
    
    }
}
