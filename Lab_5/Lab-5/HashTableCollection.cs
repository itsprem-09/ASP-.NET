using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Lab_5
{
    public class HashTableCollection
    {
        Hashtable hashTable = new Hashtable();

        public void Add()
        {
            Console.WriteLine("Enter Key : ");
            string key = Console.ReadLine()!;

            if (!hashTable.ContainsKey(key))
            {
                Console.WriteLine("Enter Value : ");
                string val = Console.ReadLine()!;
                hashTable.Add(key, val);
                //hashTable[key] = val;
            }
            else
            {
                Console.WriteLine($"{key} is already exits in Hash Table and its value is : {hashTable[key]}");
            }
        }

        public void Remove()
        {
            Console.WriteLine("Enter A key to Remove : ");
            string key = Console.ReadLine()!;
            if (hashTable.ContainsKey(key))
            {
                hashTable.Remove(key);
                Console.WriteLine($"{key} is Removed!");
            }
            else
            {
                Console.WriteLine("Key is Not Exists in hashTableionary");
            }
        }

        public bool isContainsKey()
        {
            Console.WriteLine("Enter Key to Check : ");
            string key = Console.ReadLine()!;
            return hashTable.ContainsKey(key);
        }

        public bool isContainsValue()
        {
            Console.WriteLine("Enter Value to Check : ");
            string val = Console.ReadLine()!;
            return hashTable.ContainsValue(val);
        }

        public void Clear()
        {
            hashTable.Clear();
            Console.WriteLine("hashTable is Cleared!");
        }

        public void Display()
        {
            Console.WriteLine("--------------------hashTable-----------------");
            foreach (var item in hashTable)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
