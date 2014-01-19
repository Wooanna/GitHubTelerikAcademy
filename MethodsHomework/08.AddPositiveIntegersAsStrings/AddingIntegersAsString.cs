using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

// Трябва да имплементирате собствен метод за умножение на големи числа. На нулева позиция в масива пазете единиците,
//на първа позиция – десетиците и т.н. Когато събирате 2 големи числа, 
//единиците на сумата ще е (firstNumber[0] + secondNumber[0]) % 10, десетиците ще са равни на (firstNumber[1] + secondNumber[1]) % 10 + (firstNumber[0] + secondNumber[0])/10 и т.н.

class AddPositiveIntegersAsStrings
{
    static void Main(string[] args)
    {
        BigInteger numberOne = BigInteger.Parse(Console.ReadLine());
        BigInteger numberTwo = BigInteger.Parse(Console.ReadLine());
        Reverse(numberOne, numberTwo);
    }

    private static void Reverse(BigInteger number, BigInteger numberTwo)
    {
        BigInteger[] arrayFromNOne = new BigInteger[20];
        BigInteger[] arrayFromNTwo = new BigInteger[20];

        BigInteger reminder = 1;
        BigInteger devider = 1;
        for (int i = 0; i < arrayFromNOne.Length; i++)
        {
            arrayFromNOne[i] = ((BigInteger)number % (10 * devider)) / reminder;
            arrayFromNTwo[i] = ((BigInteger)numberTwo % (10 * devider)) / reminder;
            devider *= 10;
            reminder *= 10;

        }
        // Print(arrayFromNOne);
        // Print(arrayFromNTwo);
        int carry = 0;
        BigInteger[] added = new BigInteger[20];
        for (int i = 0; i < added.Length; i++)
        {
            added[i] = arrayFromNOne[i] + arrayFromNTwo[i] + carry;
            carry = (int)added[i] / 10;
            added[i] %= 10;

        }
        // Print( added);
        ExtractResult(added);
    }

    static void ExtractResult(BigInteger[] array)
    {
        int start = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] != 0)
            {
                start = i;
                break;
            }
        }
        BigInteger result = 0;
        for (int i = start; i >= 0; i--)
        {
            result += array[i] * (BigInteger)(Math.Pow(10, i));

        }
     
        Console.WriteLine(result);
    }
    private static void Print(BigInteger[] arrayFromNOne)
    {
        for (int i = 0; i < arrayFromNOne.Length; i++)
        {
            Console.Write(arrayFromNOne[i]);
        }
        Console.WriteLine();

    }
}

