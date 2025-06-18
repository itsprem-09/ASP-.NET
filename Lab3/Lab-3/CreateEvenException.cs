using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{
    public class NotEvenNumberException : Exception
    {
        public NotEvenNumberException(string msg) : base(msg)
        {
            
        }
    }

    internal class CreateEvenException
    {
        public void GetNumber()
        {
            Console.WriteLine("Enter Number : ");
            int n = int.Parse(Console.ReadLine()!);

            if (n % 2 != 0)
            {
                throw new NotEvenNumberException("Given Number is Not Even!");
            }
            else
            {
                Console.Write("Given Number is Even!");
            }
        }
    }
}
