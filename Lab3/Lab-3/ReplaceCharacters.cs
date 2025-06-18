using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{
    internal class ReplaceCharacters
    {
        public void replaceUpperToLowerAndViceVersa(string str)
        {
            string replaced = "";
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    replaced += char.ToUpper(c);
                }
                else
                {
                    replaced += char.ToLower(c);
                }
            }
            Console.WriteLine("Replaced : "+replaced);
        }
    }
}
