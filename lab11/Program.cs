using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_int2float_implicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            float b = a;

            Console.WriteLine(a);
            Console.WriteLine($"The float value is: {b:F2}");
            Console.ReadLine();
        }
    }
}
