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
           int[] array = { 10, 30, 40, 100, 170, 50, 20, 60 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("the maximum number is " +max);
            Console.WriteLine("the minimum number is " +min);
            int sum= 0;
            sum=max+min;    
            Console.WriteLine("the sum is "+sum);
            
            Console.Read();
        }
    }
}
