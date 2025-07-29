using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Lab_5
{
    public class StackCustom
    {
        Stack<int> st = new Stack<int>();

        public void Push()
        {
            Console.WriteLine("Enter Value to add in Stack : ");
            int val = int.Parse(Console.ReadLine()!);
            st.Push(val);
        }

        public int Pop()
        {
            int val = st.Pop();
            Console.WriteLine($"Value {val} is Removed from the Stack!");
            return val;
        }

        public int Peek()
        {
            int val = st.Peek();
            Console.WriteLine($"Element At Top of Stack : {val}");
            return val;
        }

        public bool Contains()
        {
            Console.WriteLine("Enter Value to check : ");
            int val = int.Parse(Console.ReadLine()!);
            return st.Contains(val);
        }

        public void Clear()
        {
            st.Clear();
            Console.WriteLine("Stack is Cleared!");
        }

        public void Display()
        {
            foreach (var val in st)
            {
                Console.Write($"{val} ,");
            }
            Console.WriteLine();
        }
    }
}
