using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_prctice_emp_nme
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] array = new int[10];

            Console.WriteLine("Input 10 elements in array");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("elements: " , i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( "" ,array[i]);
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
