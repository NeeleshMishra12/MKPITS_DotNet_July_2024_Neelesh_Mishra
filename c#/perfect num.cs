using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_prfct_num_in_50_loop
{ 
        internal class Program
       {
                 static void Main(string[] args)
            {
                   
                  int mn, mx;
               Console.WriteLine("enter starting range of number");
                  mn= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter ending range of number");
               mx = Convert.ToInt32(Console.ReadLine());

                  for(int num=mn; num<mx; num++)
            {
                // Console.WriteLine(num);
                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum = sum + i;
                    }
                }

                 if (sum==num & num>0)
                {
                    Console.WriteLine( + num);
                }
                
            }



            Console.Read();
        }
    }
}
