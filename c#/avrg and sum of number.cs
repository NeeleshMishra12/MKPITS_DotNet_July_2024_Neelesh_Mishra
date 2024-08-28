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
            float i,  num,  sum=0 ;
            Console.WriteLine("enter the value of numbers");
            num= Convert.ToInt32(Console.ReadLine());
           for (i = 1; i <= num; i++)
           {
         Console.WriteLine(i);
         sum = sum + i;
           }

     float avg = (sum / num);
     Console.WriteLine("the sum of numbers are :"+ sum);
     Console.WriteLine( "average is :"+ avg);
     Console.Read();
        }
    }
}
