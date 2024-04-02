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
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("ERROR: Negative value entered.");
            }
            else
            {
                int sum = CalculateSum(n);
                Console.WriteLine("The sum of numbers from 1 to " + n + " is: " + sum);
            }

            Console.ReadLine();
        }

        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }


}
