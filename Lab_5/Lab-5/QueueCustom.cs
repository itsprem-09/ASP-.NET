using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Lab_5
{
    public class QueueCustom
    {
        Queue<int> queue = new Queue<int>();

        public void Enqueue()
        {
            Console.WriteLine("Enter Value to Insert : ");
            int val = int.Parse(Console.ReadLine()!);
            queue.Enqueue(val);
        }

        public int Dequeue()
        {
            Console.WriteLine("Element is Removed!");
            return queue.Dequeue();
        }

        public int Peek()
        {
            Console.WriteLine("Peek Executed!");
            return queue.Peek();
        }

        public bool Contains()
        {
            Console.WriteLine("Enter Value to Check : ");
            int val = int.Parse(Console.ReadLine()!);
            return queue.Contains(val);
        }

        public void Clear()
        {
            queue.Clear();
            Console.WriteLine("Queue is Cleared!");
        }

        public void Display()
        {
            foreach (var item in queue)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
