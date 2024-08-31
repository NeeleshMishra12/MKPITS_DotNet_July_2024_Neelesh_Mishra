using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substraction_oop
{
    class substraction
    {
        public int FirstNumber = Convert.ToInt32(Console.ReadLine());
        public int SecondNumber = Convert.ToInt32(Console.ReadLine());

        public void subs()//function
        {
            int substraction = FirstNumber - SecondNumber;
            Console.WriteLine(substraction);
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("eneter any two number");
            substraction obj = new substraction();
            obj.subs();
            Console.Read();

        }
    }
}
