using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the time period");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the rate persent");
            int rate = Convert.ToInt32(Console.ReadLine());

            int compoundinterest = (amount * rate * time) / 100;

            Console.WriteLine(" compound interest is" + compoundinterest);
            Console.ReadLine();
        }
    }
}
