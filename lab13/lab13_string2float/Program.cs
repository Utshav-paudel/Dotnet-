using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13_string2float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "50.234";
            string b = "60.765";
            float c = float.Parse(a) + float.Parse(b);

            Console.WriteLine("The sum of parsed string a and b is : {0}",c);   
            Console.ReadLine();
        }
    }
}
