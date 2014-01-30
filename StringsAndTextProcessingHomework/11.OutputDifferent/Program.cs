using System;
using System.Collections.Generic;
using System.Text;


    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number);   // Decimal

            Console.WriteLine("{0,15:X}", number); // Hexadecimal

            Console.WriteLine("{0,15:P}", number); // Percentage

            Console.WriteLine("{0,15:E}", number); // Scientific notation   
        }
    }

