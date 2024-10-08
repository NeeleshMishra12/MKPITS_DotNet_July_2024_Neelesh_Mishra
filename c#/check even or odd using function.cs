using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_even_or_odd_numbers_using_function
{
    internal class Program

    {
        public void CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("num is even number");

            }

            else
            {
                Console.WriteLine("num is odd number");
            }

        }
        static void Main(string[] args)

        {
            Program check = new Program();
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            check.CheckEvenOrOdd(num);


            Console.Read();

        }
    }
}







