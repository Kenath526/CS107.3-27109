using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            string batch;
            Console.WriteLine("Enter your batch :");
            batch = Console.ReadLine();

            Console.WriteLine("Hi " + name);
            Console.WriteLine("Your are from batch " + batch);
            Console.ReadKey();

           
           
            Console.ReadLine();
        }
    }
}
