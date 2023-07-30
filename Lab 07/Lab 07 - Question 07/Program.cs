using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07___Question_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int[] resultArray = new int[size];

            
            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

         
            Console.WriteLine("Enter values for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
            }

            
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = array1[i] + array2[i];
            }

            
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }

            
            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = array1[i] * array2[i];
                scalarProduct += resultArray[i];
            }

            
            Console.WriteLine("\nResults:");
            Console.WriteLine("Scalar Sum: " + scalarSum);
            Console.WriteLine("Vector Sum: " + string.Join(", ", resultArray));
            Console.WriteLine("Vector Product: " + string.Join(", ", resultArray));
            Console.WriteLine("Scalar Product: " + scalarProduct);

        }
    }
}
