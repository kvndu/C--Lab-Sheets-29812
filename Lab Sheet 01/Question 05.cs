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
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMultiplication Table for " + number + ":");

            for (int i = 1; i <= 10; i++)
            {
                int product = number * i;
                Console.WriteLine(number + " x " + i + " = " + product);
            }

            Console.ReadLine();
        }
    }
}
