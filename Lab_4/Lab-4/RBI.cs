using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Lab_4
{
    public class RBI
    {
        public  virtual void calculateInterest() 
        {
            Console.WriteLine("Calulate Interest of RBI");
        }
    }

    public class HDFC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calulate Interest of HDFC");
        }
    }

    public class SBI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calulate Interest of SBI");
        }
    }

    public class ICICI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calulate Interest of ICICI");
        }
    }
}
