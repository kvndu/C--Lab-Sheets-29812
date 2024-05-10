using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_07_Q02
{
        abstract class BankAccount
        {
            public double Balance { get; protected set; }

            public abstract void Deposit(double amount);
            public abstract void Withdraw(double amount);
        }
        class SavingsAccount : BankAccount
        {
            public override void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount} to the savings account. New balance: ${Balance}");
            }

            public override void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn ${amount} from the savings account. New balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance in the savings account.");
                }
            }
        }
        class CurrentAccount : BankAccount
        {
            public override void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount} to the current account. New balance: ${Balance}");
            }

            public override void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn ${amount} from the current account. New balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance in the current account.");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                SavingsAccount savings = new SavingsAccount();
                CurrentAccount current = new CurrentAccount();

                savings.Deposit(1000);
                savings.Withdraw(500);

                current.Deposit(2000);
                current.Withdraw(1500);

                Console.ReadLine();
            }
        }
    }

