﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            
            double number5 = 10.4;
            decimal number6 = 10.4m;
            char character = 'A';
            bool condition = true;
            byte number4 = 0; //0 - 255
            short number3 = -32768;
            int number1 = 10;
            long number2 = 2147483647;
            var number7 = 10;
            
            Console.WriteLine("Number 1 is {0}",number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturaday, Sunday
    }
}
