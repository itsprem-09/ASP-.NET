using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Lab_4
{
    internal class Area
    {
        public void CalculateArea(double length)
        {
            Console.WriteLine("Area of Square : " + (Math.Pow(length, 2)));
        }

        public void CalculateArea(double length, double width)
        {
            Console.WriteLine("Area of Rectangle : "+(length * width));
        }
    }
}
