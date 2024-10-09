using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove__elements_in_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>() { 1, 2, 6, 8, 9, 4 };

           
            Console.WriteLine("List before removing elements:");
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }

            elements.Remove(6);
            Console.WriteLine("List after removing elements:");

            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }

             Console.Read();

        }
    }
}
