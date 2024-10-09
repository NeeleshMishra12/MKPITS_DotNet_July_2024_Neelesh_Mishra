using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Subjects = new List<string>() { "English", "Hindi", "Math" };
            List<int> Marks = new List<int>() { 1, 2, 3 };

            Subjects.Add("Hindi");
            foreach(string sub in Subjects)
            {
                Console.WriteLine(sub+ " ");
            }

            Console.WriteLine();
            Console.Write("Enter any subject :");
            string newsub= Console.ReadLine();
            Subjects.Insert(3,newsub);
            Console.WriteLine() ;
            foreach (string sub in Subjects)
            {
                Console.WriteLine(sub + " ");
            }

            Console.Read();
        }
    }
}
