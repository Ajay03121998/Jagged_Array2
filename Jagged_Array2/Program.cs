using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jag_arr = new int[][] { new int[] { 11, 22, 33, 44 },
            new int[] { 53, 4, 69 },new int[] { 8, 2 },new int[] { 0, 4, 7, 3, 99 } };

            for (int i = 0; i < jag_arr.Length; i++)
            {
                // Print the row number
                Console.Write("Row({0}): ", i);
                for (int k = 0; k < jag_arr[i].Length; k++)
                {
                    // Print the elements in the row
                    Console.Write("{0} ", jag_arr[i][k]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
