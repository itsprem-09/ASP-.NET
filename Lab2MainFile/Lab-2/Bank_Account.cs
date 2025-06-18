using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_2
{
    internal class Bank_Account
    {
        string account_No;
        string email;
        string user_Name;
        string account_Type;
        double account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Number : ");
            this.account_No = Console.ReadLine()!;

            Console.WriteLine("Enter Email : ");
            this.email = Console.ReadLine()!;

            Console.WriteLine("Enter User Name : ");
            this.user_Name = Console.ReadLine()!;

            Console.WriteLine("Enter Account Type : ");
            this.account_Type = Console.ReadLine()!;

            Console.WriteLine("Enter Account Balance : ");
            this.account_Balance = double.Parse(Console.ReadLine()!);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number : {this.account_No}");
            Console.WriteLine($"Account Email : {this.email}");
            Console.WriteLine($"Account User Name : {this.user_Name}");
            Console.WriteLine($"Account Type : {this.account_Type}");
            Console.WriteLine($"Account Balance : {this.account_Balance} Rs.");

        }
    }
}
