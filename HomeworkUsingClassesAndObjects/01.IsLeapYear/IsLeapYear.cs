using System;
//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


    class IsLeapYear
    {
        static void Main(string[] args)
        {
                Console.Write("Please enter a year to check if it is leap: ");
                int year = int.Parse(Console.ReadLine());
                if (year < 1 || year > 9999)
                {
                    throw new ArgumentException("Invalid year");
                }
                Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }

