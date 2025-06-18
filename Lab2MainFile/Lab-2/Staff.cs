using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_2
{
    internal class Staff
    {
        string name;
        string department;
        string designation;
        double experience;
        double salary;
        

        public void GetStaffDetails()
        {
            Console.WriteLine("Enter Staff Name : ");
            this.name = Console.ReadLine()!;

            Console.WriteLine("Enter Staff Department : ");
            this.department = Console.ReadLine()!;

            Console.WriteLine("Enter Staff Description: ");
            this.designation = Console.ReadLine()!;

            Console.WriteLine("Enter Staff Experience in Years : ");
            this.experience = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Staff Salary : ");
            this.salary = double.Parse(Console.ReadLine()!);
        }

        public void DisplayStaffDetails()
        {
            if (this.designation.ToUpper() == "HOD")
            {
                Console.WriteLine($"Staff Name : {this.name}");
                Console.WriteLine($"Staff Department : {this.department}");
                Console.WriteLine($"Staff Designation : {this.designation}");
                Console.WriteLine($"Staff Experience : {this.experience} Years");
                Console.WriteLine($"Staff Salary : {this.salary} Rs");
            }
        }
    }
}
