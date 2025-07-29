using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Lab_4
{
    public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("From Hospital");
        }
    }

    public class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("From Apollo");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("From Wockgardt");
        }
    }

    public class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("From Gokul_Superspeciality");
        }
    }


}
