using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_character_dtype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = char.MinValue;
            int max = char.MaxValue;
            Console.WriteLine($"The range of char is U+{min:x4} to U+{max:x4}");
            Console.ReadLine();
        }
    }
}
