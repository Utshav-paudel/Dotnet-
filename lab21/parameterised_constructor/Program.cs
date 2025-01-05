using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace parameterised_constructor
{
    internal class Employees
    {

        int EmpId;
        string EmpName;
        int EmpAge;
        public Employees(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;  
        }
        public int getID()
        {  return this.EmpId; }
        public string getName()
        { 
            return this.EmpName; 
        }
        public int getAge()
        {
            return this.EmpAge;
        }
        static void Main(string[] args)
        {
            Employees Ram = new Employees(11, "Ram kumar Lama", 22);
            Employees Hari = new Employees(14, "Hari bahadur acharya", 29);

            Console.WriteLine( " Employees ID is {0}", Ram.getID() );
            Console.WriteLine( " Employees name is {0}", Ram.getName() );
            Console.WriteLine( " Employees age is {0}", Ram.getAge() );
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine( " Employees ID is {0}", Hari.getID() );
            Console.WriteLine("Employees name is {0}", Ram.getName());
            Console.WriteLine("Employees age is {0}", Hari.getAge() );  
            Console.ReadLine();

        }
    }
}
