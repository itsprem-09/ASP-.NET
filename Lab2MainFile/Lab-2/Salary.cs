using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2MainFile.Lab_2
{
    internal class Salary
    {
        double Basic;
        double TA;
        double DA;
        double HRA;

        public Salary(double Basic, double TA, double DA = 0.1, double HRA = 0.5)
        {
            this.Basic = Basic;
            this.TA = TA;
            this.DA = (DA / 100) * Basic;
            this.HRA = (HRA / 100) * Basic;
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary = {this.Basic + this.HRA + this.DA + this.TA}");
        }
    }
}
