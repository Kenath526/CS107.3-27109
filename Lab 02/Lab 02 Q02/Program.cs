using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.Write("Enter the first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                double sum = firstNumber + secondNumber;
                double difference = firstNumber - secondNumber;
                double product = firstNumber * secondNumber;
                double quotient = firstNumber / secondNumber;
                Console.WriteLine("The sum is: " + sum);
                Console.WriteLine("The difference is: " + difference);
                Console.WriteLine("The product is: " + product);
                Console.WriteLine("The quotient is: " + quotient);
            }
        }
    }


