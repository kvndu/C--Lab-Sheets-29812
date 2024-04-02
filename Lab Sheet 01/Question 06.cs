using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the student's exam marks (0-100): ");
            int marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Error: Invalid marks entered. Please enter a value between 0 and 100.");
            }
            else
            {
                string grade;

                if (marks >= 75 && marks <= 100)
                    grade = "A";
                else if (marks >= 60 && marks <= 74)
                    grade = "B";
                else if (marks >= 50 && marks <= 59)
                    grade = "C";
                else if (marks >= 40 && marks <= 49)
                    grade = "D";
                else
                    grade = "Fail";

                Console.WriteLine($"{name}'s grade is: {grade}");
            }

            Console.ReadLine();
        }
    }
}
