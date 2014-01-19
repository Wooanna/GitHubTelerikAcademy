using System;
using System.Collections.Generic;
using System.Text;
//You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values from given string and calculates 
//their sum. Example:
//string = "43 68 9 23 318"  result = 461

namespace CalcSumOfStringNumbers
{
    class CalculateSum
    {
        static void Main()
        {
            Console.WriteLine("Enter sequence of positive integer numbers:");
            string input = Console.ReadLine();
            Console.WriteLine( AddingNumbers(input));
        }

        private static int AddingNumbers(string input)
        {
            int number = 0;
            int power = 1;
            input = input.Trim();
            try
            {
                for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] != ' ' && !char.IsDigit(input[i]))
                {
                    throw new ArgumentException("Input not a number");
                }
                else if (i == input.Length || input[i] != ' ')
                {
                    number += ((int)input[i] - 48) * power;
                    power *= 10;
                }
                else if (input[i] == ' ')
                {
                    power = 1;
                }
            }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
            return number;
           
        }
    }
}
