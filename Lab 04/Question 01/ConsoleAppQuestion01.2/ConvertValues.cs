using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuestion01._2
{
    internal class ConvertValues
    {
        public void KilometerToMeter(double km)
        {  
            double m = km * 1000;
            Console.WriteLine(m.ToString() + "m");
        }

    }
}
