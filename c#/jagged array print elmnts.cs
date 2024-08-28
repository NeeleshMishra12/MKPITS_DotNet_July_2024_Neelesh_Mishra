using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagedd_aray
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("enter elements of array");
            int[][] ladder =  new int[4][];

            ladder[0] = new int[] { 1, 2, 3, 4 };
            ladder[1] = new int[] { 5, 6, 7 };
            ladder[2] = new int[] {8,9,10,11,12 };
            ladder[3] = new int[] { 13, 14 };

            foreach (int[] row in ladder)
            {
                foreach (int col in row)
                {
                    Console.Write(col + "\t");
                }

                Console.WriteLine();

           }
              Console.Read();
        }
    }
}
