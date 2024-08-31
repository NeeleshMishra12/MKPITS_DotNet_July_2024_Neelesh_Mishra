using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
        interface Bankdetails
        {
            void AddDetails();

            void Balance();
        }
        
     class showDetails:Bankdetails
    {
        public   void AddDetails()
        {
            Console.WriteLine("AddDetails fn invoked");
        }

        public void Balance()
        {
            Console.WriteLine("balance funvtion invoked");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            showDetails obj = new showDetails();
            obj.AddDetails();
            obj.Balance();
            Console.ReadLine();


        }
    }
}
