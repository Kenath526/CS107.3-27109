using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter employee salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter tax rate: ");
                double taxRate = Convert.ToDouble(Console.ReadLine());

                double tax = salary * taxRate;
                double salaryAfterTax = salary - tax;

                Console.WriteLine("Salary after tax: " + salaryAfterTax);
        }
    }
}
