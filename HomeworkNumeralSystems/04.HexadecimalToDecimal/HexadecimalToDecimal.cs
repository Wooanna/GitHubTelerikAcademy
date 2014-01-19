using System;
using System.Text;
//Write a program to convert hexadecimal numbers to their decimal representation.


class HexadecimalToDecimal
{
    static void Main()
    {
        int result = 0;
        string hexNumber = Console.ReadLine();

        for (int i = 0; i < hexNumber.Length; i++)
        {
            char currentChar = hexNumber[i];
            int power = hexNumber.Length - 1 - i;

            switch (currentChar)
            {
                case 'A': result = result + 10 * (int)Math.Pow(16, power); break;
                case 'B': result = result + 11 * (int)Math.Pow(16, power); break;
                case 'C': result = result + 12 * (int)Math.Pow(16, power); break;
                case 'D': result = result + 13 * (int)Math.Pow(16, power); break;
                case 'E': result = result + 14 * (int)Math.Pow(16, power); break;
                case 'F': result = result + 15 * (int)Math.Pow(16, power); break;

                default:
                    result = result + ((int)hexNumber[i] - 48) * (int)Math.Pow(16, power);
                    break;

            }
        }
        Console.WriteLine(result);
    }
}

