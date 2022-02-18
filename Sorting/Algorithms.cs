using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Algorithms
    {
        /// <summary>
        /// Arrange numbers contained in N - 1 elements of an array
        /// </summary>

        public static void sortNumbers(int[] arr)
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
            {
                Console.Write(" " + arr[k]);
            }
        }

        /// <summary>
        /// Sort a list in an alphabetical order using a two dimensional array.
        /// </summary>

        public static void sortAZOrder(string[,] arr)
        {
            string[] buffer = new string[3];

            for(int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for(int j = 0; j < arr.GetLength(0) - 1; j++)
                {
                    if (String.Compare(arr[j, 0], arr[j + 1, 0]) > 0) /// Sorting only the second column.
                    {
                        buffer[0] = arr[j, 0];
                        buffer[1] = arr[j, 1];
                        buffer[2] = arr[j, 2];

                        arr[j, 0] = arr[j + 1, 0];
                        arr[j, 1] = arr[j + 1, 1];
                        arr[j, 2] = arr[j + 1, 2];

                        arr[j + 1, 0] = buffer[0];
                        arr[j + 1, 1] = buffer[1];
                        arr[j + 1, 2] = buffer[2];

                    }
                }
            }

            for (int k = 0; k < arr.GetLength(0); k++)
            {
                Console.WriteLine(arr[k, 0] + " " + arr[k, 1] + " " + arr[k, 2]);
            }
        }
    }
}
