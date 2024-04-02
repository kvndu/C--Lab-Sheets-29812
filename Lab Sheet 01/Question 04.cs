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
            Console.Write("Enter the number of terms (N) for the Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe first " + n + " terms of the Fibonacci series are:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciTerm(i) + " ");
            }

            Console.ReadLine();
        }

        static int FibonacciTerm(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciTerm(n - 1) + FibonacciTerm(n - 2);
            }
        }
    }


}
