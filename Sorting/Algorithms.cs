using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Algorithms
    {
        public static void BubbleSort(int[] arr)
        {
            int buffer;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        buffer = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buffer;
                    }
                }
            }

            for (int k = 0; k < arr.Length; k++)
                Console.Write(" " + arr[k]);
        }
    }
}
