using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_constant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double pi = 3.14159;
            double r;
            r = 10;
            double area = pi * r * r;
            double circumference = 2 * pi * r;
            Console.WriteLine("Area of Circle : {0}", area);
            Console.WriteLine("Circumference of circel is : {0}", circumference);
            Console.ReadLine();

        }
    }
}
