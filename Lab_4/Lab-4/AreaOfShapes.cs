using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Lab_4
{
    public class AreaOfShapes
    {
        public void findArea(int radius)
        {
            Console.WriteLine("Circle : "+(Math.PI * radius * radius));
        }

        public void findArea(double length)
        {
            Console.WriteLine("Square : " + (length * length));
        }

        public void findArea(double length, double width)
        {
            Console.WriteLine("Rectangle : "+(length * width));

        }
    }
}
