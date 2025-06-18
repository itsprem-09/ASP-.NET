using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2MainFile.Lab_2
{
    internal class Distance
    {
        int dist1;
        int dist2;
        int dist3;

        public Distance(int dist1, int dist2) 
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
            this.dist3 = AdditionOfDist(dist1, dist2);
        }

        public int AdditionOfDist(int dist1, int dist2)
        {
            return dist1 + dist2;
        }

        public void DisplayDistance()
        {
            Console.WriteLine($"Total Distanace =  {dist3}");
        }

    }
}
