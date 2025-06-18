using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_2
{
    internal class Student
    {
        string enrollment_No;
        string student_Name;
        int sem;
        double cpi;
        double spi;
        
        public Student(string enrollment_No, string student_Name, int sem, double cpi, double spi)
        {
            this.enrollment_No = enrollment_No;
            this.student_Name = student_Name;
            this.sem = sem;
            this.cpi = cpi;
            this.spi = spi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student Name : {this.student_Name}");
            Console.WriteLine($"Student Enrollnent Number : {this.enrollment_No}");
            Console.WriteLine($"Student Sem : {this.sem}");
            Console.WriteLine($"Student Cpi : {this.cpi}");
            Console.WriteLine($"Student Spi : {this.spi}");
        }
    }
}
