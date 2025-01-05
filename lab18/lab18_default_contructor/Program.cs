using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_default_contructor
{
    
    internal class Program
    {
        //creating default constructor with same name program

        public Program() {
            Console.WriteLine("constructor invokes MBM");
            Console.WriteLine("This is MBM CSIT lab on default constructor");

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadLine();

        }
    }
}
