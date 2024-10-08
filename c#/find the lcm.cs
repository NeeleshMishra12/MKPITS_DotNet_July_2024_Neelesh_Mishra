using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_lcm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, x, y, lcm = 0;
            Console.WriteLine("enter first  number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second  number");
            num2 = Convert.ToInt32(Console.ReadLine());

            x = num1;
            y= num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }

                else
                {
                    num2 = num2 - num1;
                }
            }

                lcm = (x * y) / num1;

                Console.WriteLine("the lcm of number is " + lcm);


            
            Console.Read();
        }
    }
}
