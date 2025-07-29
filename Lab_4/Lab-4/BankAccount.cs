using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Lab_4
{
    public class BankAccount
    {
        public double Balance;
        public string accountHolderName;
        public BankAccount(double initialBalance, string accountHolderName)
        {
            this.Balance = initialBalance;
            this.accountHolderName = accountHolderName;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Deposit(string checkNumber, double amount)  // Check deposit
        {
            Balance += amount;
            Console.WriteLine($"Check deposit of {amount} (Check #: {checkNumber}) successful. New balance: {Balance}");
        }
    }
}
