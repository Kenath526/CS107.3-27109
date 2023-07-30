using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a positive integer: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i <= n; i += 2)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of all the odd numbers from 1 to " + n + " is: " + sum);
            }
        }
    }


