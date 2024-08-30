using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list_remove_elemets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>() { 1, 2, 3, 4, 5, 7, 8, 9, 11 };

            Console.WriteLine("Elements in array are");
            for (int counter = 0; counter < elements.Count; counter++)
            {
                Console.WriteLine(elements[counter]);
            }

            Console.WriteLine("After adding two elements ");
            elements.Add(6);
            elements.Add(10);
            foreach (int numbr in elements)
            {
                Console.WriteLine(numbr);
            }

            elements.Remove(5);
            foreach (int numbr in elements)
            {
                Console.WriteLine(numbr);
            }
             
            Console.Read();
       }
   }
}
