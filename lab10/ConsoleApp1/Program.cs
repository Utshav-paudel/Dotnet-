using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_stringhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Welcome to cSharp MBM class A";
            string b = "\"Welcome to CSharp MBM Class B\"";
            string c = "\\Welcome to CSharp MBM Class C\\";
            string d = "\t Welcome to CSharp MBM Class D";
            string e = "One\nTwo\nThree ";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
