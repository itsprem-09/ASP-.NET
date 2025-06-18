using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_2
{
    internal class Acount_Details
    {
        public string actNo;
        public double balance;
        public string actHolderName;
        public double interest;

        public void GetAcountDeatails()
        {
            Console.WriteLine("Enter Acount Number : ");
            this.actNo = Console.ReadLine()!;

            Console.WriteLine("Enter Balance : ");
            this.balance = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Acount Holder Name : ");
            this.actHolderName = Console.ReadLine()!;

            Console.WriteLine("Enter Interest Rate : ");
            this.interest = double.Parse(Console.ReadLine()!);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n--- Account Information ---");
            Console.WriteLine("Account Number       : " + actNo);
            Console.WriteLine("Account Holder Name  : " + actHolderName);
            Console.WriteLine("Account Balance      : $" + balance);
            Console.WriteLine("Interest Rate        : " + interest + "%");
        }
    }

    class Interest : Acount_Details
    {
        public void CalculateInterest()
        {
            Console.Write("\nEnter Time Period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double interestAmount = (balance * interest * time) / 100;

            Console.WriteLine("\n--- Interest Details ---");
            Console.WriteLine("Total Interest for {0} years: ${1:F2}", time, interestAmount);
        }
    }
}
