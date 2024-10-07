using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rem, temp,sum = 0;
            Console.Write("Enter a Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem );
                n = n / 10;
            }
            Console.Write("the output number is: "+sum);
            Console.WriteLine();
            
            if(sum==temp)
            {
                Console.WriteLine(sum + " is a armstrong number");
            }
            else
            {
                Console.WriteLine(temp + " not an armstrong number");
            }
            Console.ReadLine();
        }
    }
}
