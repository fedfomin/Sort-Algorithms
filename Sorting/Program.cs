using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // sorting numbers
            int[] nums = new int[5] { 4, 91, 82, 5, 21 };
            Algorithms.sortNumbers(nums);

            Console.Write("\n\n");

            // sorting a list in an alphabetical order
            string[,] people = new string[5, 3]
            {
                { "Mario", "Rossi", "24" },
                { "Valerio", "Nero", "32" },
                { "Alessandro", "DeNegri", "21" },
                { "Francesco", "DellaTorre", "12" },
                { "Marco", "Francia", "21" }
            };

            Algorithms.sortAZOrder(people);
        }
    }
}
