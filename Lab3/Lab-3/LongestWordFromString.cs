using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Lab_3
{
    internal class LongestWordFromString
    {
        public void longestWord(string str) 
        {
            string[] strings = str.Split(' ');
            int maxLength = 0;
            string maxWord = string.Empty;
            foreach (string s in strings)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                    maxWord = s;
                }
            }
            Console.WriteLine("Max Word From String : "+maxWord);
        }
    }
}
