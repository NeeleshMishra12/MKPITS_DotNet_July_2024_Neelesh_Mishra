using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_natural_number_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("enter number");
            num= Convert.ToInt32(Console.ReadLine());   

            for(i=num; i>0; i--)
            {
                Console.WriteLine(i);


            }
            Console.Read();
        }
    }
}
