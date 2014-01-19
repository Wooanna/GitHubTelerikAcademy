using System;
using System.Text;
//Write a program to convert hexadecimal numbers to binary numbers (directly).
class HexadecimalToBinary
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        StringBuilder stringBuild = new StringBuilder();
        for (int i = 0; i < hexNumber.Length; i++)
        {
            char currentChar = hexNumber[i];
            switch (currentChar)
            {
                case '0': stringBuild.Append("0000"); break;
                case '1': stringBuild.Append("0001"); break;
                case '2': stringBuild.Append("0010"); break;
                case '3': stringBuild.Append("0011"); break;
                case '4': stringBuild.Append("0100"); break;
                case '5': stringBuild.Append("0101"); break;
                case '6': stringBuild.Append("0110"); break;
                case '7': stringBuild.Append("0111"); break;
                case '8': stringBuild.Append("1000"); break;
                case '9': stringBuild.Append("1001"); break;
                case 'A': stringBuild.Append("1010"); break;
                case 'B': stringBuild.Append("1011"); break;
                case 'C': stringBuild.Append("1100"); break;
                case 'D': stringBuild.Append("1101"); break;
                case 'E': stringBuild.Append("1110"); break;
                case 'F': stringBuild.Append("1111"); break;
                default:
                    throw new ArgumentException("Invalid input");
                    break;
            }
        }

        Console.WriteLine(stringBuild);


    }
}

