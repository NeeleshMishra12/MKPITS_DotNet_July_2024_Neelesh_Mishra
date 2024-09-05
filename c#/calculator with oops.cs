using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_oops
{

    public class calculator
    {
        
        int result;

        public void addition(int a, int b)
        {
            result = a + b;
            Console.WriteLine("the result is " + result);
        }

        public void subtraction(int a, int b)
        {
            result = a - b;
            Console.WriteLine("the result is " + result);
        }

        public void multiply(int a, int b)
        {
            result = a * b;
            Console.WriteLine("the result is " + result);
        }

        public void division(int a, int b)
        {
            result = a / b;
            Console.WriteLine("the result is " + result);
        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {

                  calculator calc=  new calculator();

            Console.WriteLine("enter first number");
                int num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter operator(+,*,/,-)");
            string opr= Console.ReadLine(); 

            if(opr== "+")
            {
                calc.addition(num1, num2);
            }
            else if(opr== "-")
            {
                calc.subtraction(num1, num2);
            }
            else if (opr== "*")
            {
                calc.multiply(num1, num2);
            }
            else if(opr == "/")
            {
                calc.division(num1, num2);
            }
               
            Console.Read();




        }
    }
    }
