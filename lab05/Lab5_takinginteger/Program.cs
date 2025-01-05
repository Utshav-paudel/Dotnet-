using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_takinginteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = int.Parse(Console.ReadLine());   
            int sum = num1 + num2;  
            Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, sum);
            Console.ReadLine();
        }
    }
}
