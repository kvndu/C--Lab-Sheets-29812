using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit of ${amount} successful. New balance: ${Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.AccountNumber = "12345";

            account.Balance = 1000.0;

            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${account.Balance}");

            account.Deposit(500.0);

            Console.ReadLine();
        }
    }
}
