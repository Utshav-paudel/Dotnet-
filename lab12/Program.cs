using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_float2int_explicitconversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 34.4352f;
            int b = (int)a;
            //int b = Convert.ToInt32(a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
