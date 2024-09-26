using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alph, digit, splchr ,i;
            alph= digit= splchr =i = 0;

            Console.WriteLine("enter the string");
            str = Console.ReadLine();
           int l = str.Length;

             while(i <l)
            {
                if ((str[i] >='a' && (str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')))
                    {
                    alph++;
                }

                else if ((str[i] > '0' && str[i] < '9'))
                {

                    digit++;
                }


                else
                {
                    splchr++;
                }
                i++;
              }
                Console.WriteLine("alphabet in string " +alph);
            Console.WriteLine("digit in string "+digit);
            Console.WriteLine("special character "+ splchr);
            Console.Read();

        }
    }
}
