﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07___Question_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            animal.Display();
           
            dog.DisplayDog(); 
        }
    }
}
