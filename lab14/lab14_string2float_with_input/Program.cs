using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_string2float_with_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            float b = float.Parse(Console.ReadLine());  

            float c = a + b;
            Console.WriteLine("The sum of string a={0} and b={1} is : {2}",a,b,c);
            Console.ReadLine();

        }
    }
}
