using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_2
{
    internal class Candinate
    {
        int id;
        string name;
        int age;
        double weight;
        double height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Candidate Id : ");
            this.id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Candidate Name : ");
            this.name = Console.ReadLine()!;

            Console.WriteLine("Enter Candidate Age : ");
            this.age = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Candidate Weight in Kg : ");
            this.weight = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Candidate Height in Inch : ");
            this.height = double.Parse(Console.ReadLine()!);
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Candidate Name : {this.name}");
            Console.WriteLine($"Candidate Id : {this.id}");
            Console.WriteLine($"Candidate Age : {this.age}");
            Console.WriteLine($"Candidate Weight : {this.weight} Kg");
            Console.WriteLine($"Candidate Height : {this.height} Inch");
        }
    }
}
