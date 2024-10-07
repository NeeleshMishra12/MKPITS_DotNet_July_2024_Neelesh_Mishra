using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_first_and_last_digit_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, last;
            Console.WriteLine("enter any number");
            num=Convert.ToInt32(Console.ReadLine());

             last = num % 10;
            Console.WriteLine("the last digit of number is " + last);


            int firstDigit = num;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            Console.WriteLine("the first digit of number is" + firstDigit);
            Console.Read();
        }
    }
}
