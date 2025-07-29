using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Lab_4
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal");
        }
    }

    public class Dog : Animal 
    {
        public Dog()
        {
            Console.WriteLine("Dog");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
        }
    }
}
