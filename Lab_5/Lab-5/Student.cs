using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Lab_5
{
    public class Student
    {
        ArrayList studentNames = new ArrayList();

        List<String> studentName = new List<String>();

        public void Add()
        {
            Console.WriteLine("Enter Student Name : ");
            string name = Console.ReadLine()!;
            studentNames.Add(name);
            studentName.Add(name);
            Console.WriteLine($"Student with {name} is added in the List");
        }

        public void Remove() 
        {
            Console.WriteLine("Enter Index to Remove : ");
            int index = int.Parse( Console.ReadLine()!);
            studentNames.RemoveAt(index);
            studentName.RemoveAt(index);
            Console.WriteLine($"Student at {index} is Removed!");
        }

        public void RemoveRange()
        {
            Console.WriteLine("Enter Starting Range : ");
            int startingRange = int.Parse( Console.ReadLine()!);
            Console.WriteLine("Enter Ending Range : ");
            int endingRange = int.Parse( Console.ReadLine()!);
            studentNames.RemoveRange(startingRange, endingRange);
            studentName.RemoveRange(startingRange, endingRange);
            Console.WriteLine($"Students from {startingRange} to {endingRange} are removed.");
        }

        public void Clear()
        {
            studentNames.Clear();
            studentName.Clear();
            Console.WriteLine("All Students Are Deleted!");
        }

        public void Display()
        {
            Console.WriteLine("--------------------------");
            foreach(var stu in studentNames)
            {
                Console.Write($"{stu}, ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            foreach (var stu in studentName)
            {
                Console.Write($"{stu}, ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------");

        }
    }
}
