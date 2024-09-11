using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("enter the  value of radius");
            radius = Convert.ToInt32(Console.ReadLine());

            double area= Math.PI *radius*radius;
             Console.WriteLine("area of circle is" + area);

            Console.Read();
        }
    }
}
