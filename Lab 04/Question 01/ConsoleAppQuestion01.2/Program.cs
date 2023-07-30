using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuestion01._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter km value:");
            double km = double.Parse(Console.ReadLine());
            ConvertValues obj = new ConvertValues();
            obj.KilometerToMeter(km);

            Console.ReadKey();

        }
    }
}
