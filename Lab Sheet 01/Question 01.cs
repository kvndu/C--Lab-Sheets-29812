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
            Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            Console.WriteLine("The area of the rectangle is: " + area);

            Console.ReadLine(); // Pause the program to see the output
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

    }
}