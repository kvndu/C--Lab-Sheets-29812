 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to the Calculator!");
                    Console.Write("Enter the first number: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the operation (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    Console.Write("Enter the second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double result;
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            }
                            break;
                        default:
                            Console.WriteLine("Error: Invalid operation. Please enter +, -, *, or /.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }

                Console.Write("Do you want to perform another calculation? (y/n): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the Calculator!");
        }

    }
}

    

