using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angel
{
    internal class GenerateRandom
    {
        public static int[] GenerateRandomArray(int min, int max)
        {
            Random random = new Random();
            int min2 = Math.Abs(min);
            int max2 = Math.Abs(max);   
            int count = min2 + max;
            int[] array = new int[count];
            for (int i = 0; i < count ; i++)
            {
                array[i] = min++;
            }
            return array;
        }
    }
}
