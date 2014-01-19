﻿using System;

//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


    class DigitAsWord
    {
        static void Main(string[] args)
        {
            double number;
            do
            {
                Console.WriteLine("Please enter a number"); 
            } while (!double.TryParse(Console.ReadLine(), out number));
            DigitWord(number);
        }

        private static void DigitWord(double i)
        {
            
            string number = Convert.ToString(i);

            char lastNumber = number[number.Length - 1];
            switch (lastNumber)
            {
                case '1': Console.WriteLine("One"); break;
                case '2': Console.WriteLine("Two"); break;
                case '3': Console.WriteLine("Tree"); break;
                case '4': Console.WriteLine("Four"); break;
                case '5': Console.WriteLine("Five"); break;
                case '6': Console.WriteLine("Six"); break;
                case '7': Console.WriteLine("Seven"); break;
                case '8': Console.WriteLine("Eight"); break;
                case '9': Console.WriteLine("Nine"); break;
                case '0': Console.WriteLine("Zero"); break;

                default:
                    break;
            }
        }
    }

