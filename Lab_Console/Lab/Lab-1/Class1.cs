using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console.Lab.Lab_1
{
    internal class Lab1
    {
        public static void name()
        {
            Console.WriteLine("Name : Prem Jani");
            Console.WriteLine("Address : Swaminarayan Chowk");
            Console.WriteLine("Contact : 9624021450");
            Console.WriteLine("City : Rajkot");
        }

        public static void printTwoNumbers()
        {
            Console.WriteLine("Enter Number 1 : ");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Number 2 : ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Two Numbers are : " + a + " " + b);
        }

        public static void printNameCountry()
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter Country : ");
            string country = Console.ReadLine()!;
            Console.WriteLine($"Hello {name} from country {country}");
        }

        public static void calculateArea()
        {
            Console.WriteLine("Enter Length : ");
            double length = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Width : ");
            double width = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Area = {length * width}");
        }

        public static void area_square_rect_circle()
        {
            Console.WriteLine("Enter From Following Option : ");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.WriteLine("Enter Length : ");
                int length = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"Area of Square = {length * length}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Length : ");
                double length = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter Width : ");
                double width = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Area = {length * width}");
            }
            else
            {
                Console.WriteLine("Enter Radius : ");
                double rad = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Area of Circle = {3.14 * rad * rad}");
            }
        }

        public static void convertTemprature()
        {
            Console.WriteLine("Enter Your Choice : ");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.WriteLine("Enter Celsius : ");
                double cel = double.Parse(Console.ReadLine()!);
                double feh = (cel * 9 / 5) + 32;
                Console.WriteLine("Fehrenheit = " + (feh));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Fahrenheit : ");
                double feh = double.Parse(Console.ReadLine()!);
                double cel = (feh - 32) * 5 / 9;
                Console.WriteLine("Celsius = " + (cel));
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }

        private static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }

        public static void simpleInterest()
        {
            Console.Write("Enter Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double interest = CalculateSimpleInterest(principal, rate, time);

            Console.WriteLine($"Simple Interest = {interest:F2}");
        }

        public static void calculatorUsingIfElse()
        {
            Console.WriteLine("Enter Number 1 : ");
            double num1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Number 2 : ");
            double num2 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Operation : ");
            char operation = (char)Console.Read();

            if (operation == '+')
            {
                Console.WriteLine($"Sum = {num1 + num2}");
            }
            else if (operation == '-')
            {
                Console.WriteLine($"Sub = {num1 - num2}");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"Mul = {num1 * num2}");
            }
            else if (operation == '/')
            {
                Console.WriteLine($"Div = {num1 / num2}");
            }
            else if (operation == '%')
            {
                Console.WriteLine($"Mod = {num1 % num2}");
            }
            else
            {
                Console.WriteLine("Wrong Operation Called");
            }
        }

        public static void calculatorUsingSwitch()
        {
            Console.WriteLine("Enter Number 1 : ");
            double num1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Number 2 : ");
            double num2 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Operation : ");
            char operation = (char)Console.Read();

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Sum = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Sub = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Mul = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"Div = {num1 / num2}");
                    break;
                case '%':
                    Console.WriteLine($"Mod = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public static void swapWithoutThird()
        {
            int a = 5;
            int b = 10;
            //a = a + b;
            //b = a - b;
            //a = a - b;

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"a : {a} b : {b}");
        }

        public static void maxOfThree()
        {
            int a = 10;
            int b = 5;
            int c = 9;

            int max = a > b ? a > c ? a : c : b > c ? b : c;

            Console.WriteLine(max);
        }
    }
}