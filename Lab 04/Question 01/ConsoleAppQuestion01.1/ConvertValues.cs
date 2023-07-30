using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuestion01._1
{
    internal class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.WriteLine("Enter km value:");
            double km = double.Parse(Console.ReadLine());
            double m = km * 1000;
            Console.WriteLine(m.ToString() + "m");
        }
    }



}
