using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{

    public interface Shape
    {
        public void Circle();
        public void Triangle();
        public void Square();
    }

    public class CalculateArea : Shape
    {

        public void Circle()
        {
            Console.WriteLine("Enter Radius :");
            double rad = Double.Parse(Console.ReadLine()!);
            Console.WriteLine("Area Of Circle : " +(Math.PI * Math.Pow(rad, 2)));
        }

        public void Triangle() 
        {
            Console.WriteLine("Enter Base : ");
            double baseTriangle = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Height : ");
            double height = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Area of Triangle : "+(0.5 * baseTriangle * height));

        }

        public void Square() 
        {
            Console.WriteLine("Enter Length : ");
            double length = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Area of Square : "+(Math.Pow(length, 2)));

        }


    }
}
