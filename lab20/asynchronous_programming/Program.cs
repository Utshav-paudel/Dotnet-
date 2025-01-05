using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace lab19_synchronous_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }

        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 starting ..");
                Thread.Sleep(1000);
                Console.WriteLine("Task 1 completed");
            });
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 starting ..");
                Thread.Sleep(3000);
                Console.WriteLine("Task 2 completed");
            });


        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 starting ..");
                Thread.Sleep(2000);
                Console.WriteLine("Task 3 completed");
            });
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 starting ..");
                Thread.Sleep(5000);
                Console.WriteLine("Task 4 completed");
            });
        }
    }
}