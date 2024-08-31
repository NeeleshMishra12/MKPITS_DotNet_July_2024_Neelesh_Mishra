using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_subtract_using_constructor
{
    class Base
    {

        public void fnBase()
        {
            Console.WriteLine("i am base class");


        }

    
        public  void Add()
        {
            Console.WriteLine("constructor invoked");
        }

    

        class Derived : Base
        {

        }

       internal class Program
        {
            static void Main(string[] args)
            {
                Derived d = new Derived();
                d.fnBase();

                Console.ReadLine();

            }
        }
    }

}
