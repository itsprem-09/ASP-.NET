using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2MainFile.Lab_2
{
    public interface Gross
    {
        public void Gross_sal();
    }

    public class Employee
    {
        public string Name;
        public double Basic;

        public void basic_sal()
        {
            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            Basic = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Salary_Employee : Employee, Gross
    {
        double HRA;
        double TA;
        double DA;
        double GrossSalary;

        public void Disp_sal()
        {
            HRA = Basic * 0.20;
            TA = Basic * 0.10;
            DA = Basic * 0.15;

            Console.WriteLine($"\n--- Salary Details for {Name} ---");
            Console.WriteLine($"Basic Salary: {Basic}");
            Console.WriteLine($"HRA: {HRA}");
            Console.WriteLine($"TA: {TA}");
            Console.WriteLine($"DA: {DA}");
        }

        public void Gross_sal()
        {
            GrossSalary = Basic + HRA + TA + DA;
            Console.WriteLine($"Gross Salary: {GrossSalary}");
        }

    }

    internal class GrossSalaryEmployee
    {

    }
}
