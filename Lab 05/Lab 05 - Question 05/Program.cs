using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05___Question_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Enter 10 values for the array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int minimum = ArrayOperations.FindMinimum(array);
            int maximum = ArrayOperations.FindMaximum(array);
            double average = ArrayOperations.FindAverage(array);

            ArrayOperations.ReverseArray(array);

            Console.WriteLine("\nResults:");
            Console.WriteLine("Minimum value: " + minimum);
            Console.WriteLine("Maximum value: " + maximum);
            Console.WriteLine("Average value: " + average);
            Console.WriteLine("Array in reverse order: " + string.Join(", ", array));
        }
    }
}
