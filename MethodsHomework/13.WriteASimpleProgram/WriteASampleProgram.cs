using System;
using System.Collections.Generic;
using System.Text;
/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 'R' to reverse number.\n'A' to find average value. \n'L' for solving linear equation");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "R": ReverseDigits();
                break;
            case "A": FindAverageNumber();
                break;
            case "L": LinearEquation();
                break;
            default:
                throw new ArgumentException(" Invalid choise. ");
        }
    }

    private static void LinearEquation()
    {
        double a;
        double b;
        double x;
        do
        {
            Console.Write("Please enter number 'a':");
        } while (!double.TryParse(Console.ReadLine(), out a));

        do
        {
            Console.Write("Please enter number 'b':");
        } while (!double.TryParse(Console.ReadLine(), out b));

        x = -b / a;
        Console.WriteLine(x);
    }

    private static void FindAverageNumber()
    {
        int numbersCount = 0;
        double sum = 0;
        double number = 0;
        int divider = 0;

        Console.Write("How many numbers will you use?");
        numbersCount = int.Parse(Console.ReadLine());
        divider = numbersCount;
        Console.Write("Please enter the {0} numbers you wish to work with: ", numbersCount);
        while (numbersCount != 0)
        {
            Console.Write("Please enter a number");

            if (!double.TryParse(Console.ReadLine(), out number))
            {

                Console.WriteLine("Not a valid number");
            }
            else
            {
                sum += number;
                numbersCount--;
            }
        }

        double result = sum / divider;
        Console.WriteLine("Average number is {0}", result);
    }

    private static void ReverseDigits()
    {
        Console.Write("Please enter your number: ");
        string number = Console.ReadLine();
        StringBuilder stringBuild = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if ((char.IsDigit(number[i])) || (number[i] == '.'))
            {
                stringBuild.Append(number[i]);
            }
            else
            {
                throw new ArgumentException("Invalid Input");
            }
        }

        Console.WriteLine(stringBuild);
    }
}

