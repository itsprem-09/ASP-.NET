using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{
    public interface CalculateInterface
    {
        public void Addition();
        public void Subtraction();
    }

    public class Result : CalculateInterface
    {
        public void Addition()
        {
            int a = 6;
            int b = 7;
            Console.WriteLine(a + b);
        }

        public void Subtraction()
        {
            int a = 6;
            int b = 7;
            Console.WriteLine(a - b);
        }
    }
}
