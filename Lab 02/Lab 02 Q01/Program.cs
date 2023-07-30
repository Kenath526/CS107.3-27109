using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the Number 01: ");
                double Number01 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Number 02: ");
                double Number02 = Convert.ToDouble(Console.ReadLine());
                double sum = Number01 + Number02;
                Console.WriteLine("The sum is: " + sum);
            }
        }
    }


    

