using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();
                int vowelCount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        vowelCount++;
                    }
                }
                Console.WriteLine("The number of vowels in the string is: " + vowelCount);
            }
        }
    }


