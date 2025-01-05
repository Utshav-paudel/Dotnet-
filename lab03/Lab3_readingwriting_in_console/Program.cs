using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_readingwriting_in_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();   
            //Console.WriteLine("Your name is : " + name);
            Console.WriteLine(" Your name is {0} ", name);
            Console.ReadLine();
        }
    }
}
