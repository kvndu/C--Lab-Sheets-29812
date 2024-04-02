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
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEven/Odd Numbers:");
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i] + " is even.");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is odd.");
                }
            }

            Console.ReadLine();
        }
    }


}
