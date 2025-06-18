using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2MainFile.Lab_2
{
    internal class Furniture
    {
        public string material;
        public double price;

        public void GetFurnitureDetails()
        {
            Console.WriteLine("Enter Material : ");
            this.material = Console.ReadLine()!;

            Console.WriteLine("Enter Price : ");
            this.price = double.Parse(Console.ReadLine()!);
        }

        public void DisplayFurnitureDetails()
        {
            Console.WriteLine("\n--- Furniture Details ---");
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Price   : $" + price);
        }
    }

    class Table : Furniture
    {
        double height;
        double surface_area;

        public void GetTableDetails()
        {
            Console.Write("Enter Height of Table (in cm): ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Surface Area of Table (in sq cm): ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayTableDetails()
        {
            DisplayFurnitureDetails();

            Console.WriteLine("--- Table Specific Details ---");
            Console.WriteLine("Height       : " + height + " cm");
            Console.WriteLine("Surface Area : " + surface_area + " sq cm");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Table table = new Table();
            table.GetFurnitureDetails();
            table.GetTableDetails();

            table.DisplayTableDetails();
        }
    }
}
