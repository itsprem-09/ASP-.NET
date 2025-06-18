using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{
    internal class ChangeCaseOfChar
    {
        public void ChangeCaseOfEnteredCharacter()
        {
            Console.WriteLine("Enter Character : ");
            char c = (char) Console.Read();
            if (char.IsUpper(c))
            {
                c = char.ToLower(c);
            }
            else
            {
                c = char.ToUpper(c);
            }
            Console.WriteLine(c);
        }
    }
}
