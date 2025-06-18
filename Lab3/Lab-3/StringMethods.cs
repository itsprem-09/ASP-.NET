using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{
    internal class StringMethods
    {
        public void methods()
        {
            String name = "Prem";

            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Contains("re"));
            Console.WriteLine(name.EndsWith("m"));
            Console.WriteLine(name.IndexOf("r"));
            Console.WriteLine(name.LastIndexOf("re"));
            Console.WriteLine(name.Remove(2, 1)); // start index, length count
            Console.WriteLine(name.StartsWith("re"));
            Console.WriteLine(name.Concat(" Jani"));
            Console.WriteLine(name.Substring(2, 2)); // start index, length
            Console.WriteLine(name.Reverse());






        }
    }
}
