using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class CreateDivideByZero
    {
        int a = 10;
        int b = 0;
        double ans;

        public void Division()
        {
            try
            {
                ans = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Ans = " + ans);
            }
        }
    

    }
}
