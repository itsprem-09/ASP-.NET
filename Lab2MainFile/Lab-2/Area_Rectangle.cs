using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_2
{
    internal class Area_Rectangle
    {
        double height;
        double width;
        public Area_Rectangle(double height, double width) 
        { 
            this.height = height;
            this.width = width;
            DisplayArea();
        }
        private void DisplayArea()
        {
            Console.WriteLine($"Area = {height * width}");
        }
    }
}
