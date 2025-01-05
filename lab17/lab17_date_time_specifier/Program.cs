using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17_date_time_specifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Date/Time specifier m {0:m}", dt);
            Console.WriteLine("Date/Time specifier G {0:G}", dt);
            Console.WriteLine("Date/Time specifier M {0:M}", dt);
            Console.WriteLine("Date/Time specifier t {0:t}", dt);
            Console.WriteLine("Date/Time specifier T {0:T}", dt);
            Console.WriteLine("Date/Time specifier y {0:y}", dt);
            Console.WriteLine("Date/Time specifier yy {0:yy}", dt);
            Console.WriteLine("Date/Time specifier yyyy {0:yyyy}", dt);
            Console.WriteLine("Date/Time specifier ddd {0:ddd}", dt);
            Console.WriteLine("Date/Time specifier dddd {0:dddd}", dt);
            Console.WriteLine("Date/Time specifier HH {0:HH}", dt);
            Console.WriteLine("Date/Time specifier MM {0:MM}", dt);
            Console.WriteLine("Date/Time specifier MMM {0:MMM}", dt);
            Console.WriteLine("Date/Time specifier ss {0:ss}", dt);
            Console.WriteLine("Date/Time specifier HH:mm:ss:tt {0:HH:mm:ss:tt}", dt);
            Console.WriteLine("Date/Time specifier dd-MM-yyyy {0:dd-MM-yyyy}", dt);
            Console.WriteLine("Date/Time specifier dd/MM/yyyy {0:dd/MM/yyyy}", dt);
            Console.ReadLine();






        }
    }
}
