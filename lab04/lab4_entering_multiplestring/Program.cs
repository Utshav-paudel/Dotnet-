using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_entering_multiplestring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname");
            string fname= Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();  
            Console.WriteLine("Your name is : " +fname +" " +lname);
            Console.WriteLine("Your name is {0} {1}", fname, lname);
            Console.ReadLine();
        }
    }
}
