using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class CreateArrayIndex
    {
        public int[] arr = new int[5];

        public void ReadArray()
        {
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Enter Element in Array : ");
                    arr[i] = int.Parse(Console.ReadLine()!);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Array : \n"+ string.Join(", ", arr));
            }
            
        }
    }
}
