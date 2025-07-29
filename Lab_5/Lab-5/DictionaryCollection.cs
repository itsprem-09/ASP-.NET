using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Lab_5
{
    public class DictionaryCollection
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public void Add()
        {
            Console.WriteLine("Enter Key : ");
            string key = Console.ReadLine()!;

            if (!dict.ContainsKey(key))
            {
                Console.WriteLine("Enter Value : ");
                string val = Console.ReadLine()!;
                dict.Add(key, val);
                //dict[key] = val;
            }
            else
            {
                Console.WriteLine($"{key} is already exits in Dictionary and its value is : {dict[key]}");
            }
        }

        public void Remove() 
        {
            Console.WriteLine("Enter A key to Remove : ");
            string key = Console.ReadLine()!;
            if (dict.ContainsKey(key))
            {
                dict.Remove(key);
                Console.WriteLine($"{key} is Removed!");
            }
            else
            {
                Console.WriteLine("Key is Not Exists in Dictionary");
            }
        }

        public bool isContainsKey() 
        {
            Console.WriteLine("Enter Key to Check : ");
            string key = Console.ReadLine()!;
            return dict.ContainsKey(key);
        }

        public bool isContainsValue()
        {
            Console.WriteLine("Enter Value to Check : ");
            string val = Console.ReadLine()!;
            return dict.ContainsValue(val);
        }

        public void Clear() 
        {
            dict.Clear();
            Console.WriteLine("Dict is Cleared!");
        }

        public void Display()
        {
            Console.WriteLine("--------------------Dict-----------------");
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

        }
    }
}
