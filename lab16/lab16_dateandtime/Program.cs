using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16_dateandtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("format specifier d {0:d}",dt);
            Console.WriteLine("format specifier D {0:D}", dt);
            Console.WriteLine("format specifier f {0:f}", dt);
            Console.WriteLine("format specifier F {0:F}", dt);
            Console.WriteLine("format specifier g {0:g}", dt);

            Console.ReadLine();


        }
    }
}
