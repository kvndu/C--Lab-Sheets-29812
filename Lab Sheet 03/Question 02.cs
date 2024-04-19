using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        class Employee
        {
            public int employeeID { get; }
            public string FullName { get; set; }
            private double salary;

            public Employee(int id, string name, double salary)
            {
                employeeID = id;
                FullName = name;
                this.salary = salary;
            }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Employee ID: {employeeID}");
                Console.WriteLine($"Full Name: {FullName}");
                Console.WriteLine($"Salary: {salary}");
            }
        }

        class Progam
        {
            static void Main(string[] args)
            {
                Employee employee = new Employee(101, "John Doe", 50000);


                Console.WriteLine($"Employee ID: {employee.employeeID}");


                employee.FullName = "Jane Smith";

                employee.DisplayEmployeeInfo();
            }
        }
    }
}

