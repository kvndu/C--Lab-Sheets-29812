using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet
{
    class TemperatureTracker
    {
        private double[] temperatures = new double[7];

        public void InputTemperatures()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                temperatures[i] = double.Parse(Console.ReadLine());
            }
        }

        public void DisplayTemperatures()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();

            Console.WriteLine("Enter temperatures for the week:");
            tracker.InputTemperatures();

            tracker.DisplayTemperatures();

            Console.ReadLine();
        }
    }
}
