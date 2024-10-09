using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_integers_in_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1,2,3,4,5};

            numbers.Add(7);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Insert(4, 8);
            Console.WriteLine("after insert");
            foreach (int number in numbers)
            {
                
                Console.WriteLine(number);
            }
            Console.Read();
        }
    }
}
