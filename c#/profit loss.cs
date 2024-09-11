using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_profitloss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the cost price");  
            int cp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the selling price");
            int sp= Convert.ToInt32(Console.ReadLine());    

            int profit = sp-cp;
            int loss = cp-sp;

            if (sp > cp)
            {
                Console.WriteLine("the profit is" + profit);
            }

            else
            {
                Console.WriteLine("the loss is" + loss);
            }
            

            Console.Read();
        }
    }
}
