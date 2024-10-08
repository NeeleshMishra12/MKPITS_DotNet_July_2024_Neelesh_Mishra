using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_two_numbers_using_function
{
    internal class Program
    {
        
        public int Add( int number1, int number2)
        {
            return number1 + number2;
        }
        static void Main(string[] args)

        {
             Program add= new Program();
             

            Console.WriteLine("enter first number");
             int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2= Convert.ToInt32(Console.ReadLine());

            int result=  add.Add(num1, num2);

            Console.WriteLine("the total of numbers is" + result);

            Console.Read();
        }
    }
}
