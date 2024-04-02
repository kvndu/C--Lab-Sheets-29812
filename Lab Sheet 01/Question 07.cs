using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet
{
    internal class Program
    {
        static double balance = 1000.0;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                {
                    Console.WriteLine("\nATM Menu:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CheckBalance();
                            break;
                        case 2:
                            DepositMoney();
                            break;
                        case 3:
                            WithdrawMoney();
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using the ATM. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            } while (choice != 4);

            Console.ReadLine();
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: $");
            double amount = double.Parse(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: $");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal amount exceeds your balance.");
            }
        }
    }
}
