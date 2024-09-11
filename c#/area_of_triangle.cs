using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        { 
              double side1,side2,side3;
            Console.WriteLine("Enter the first side of triangle");
            side1= Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter the second side of triangle");
            side2= Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter the third side of triangle");
            side3= Convert.ToDouble (Console.ReadLine());

            double semiparameter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiparameter * (semiparameter - side1) * (semiparameter - side2) * (semiparameter - side3));

            Console.WriteLine("area of triange is " + area);

            Console.Read();
        }

    }
}
