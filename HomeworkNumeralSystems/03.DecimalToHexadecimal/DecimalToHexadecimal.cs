using System;
using System.Text;
//Write a program to convert decimal numbers to their hexadecimal representation

class DecimalToHexadecimal
{
    static void Main()
    {
        StringBuilder stringBuild = new StringBuilder();
        int number;
        int result;
        do
        {
            Console.WriteLine("Enter a number: ");
        } while (!int.TryParse(Console.ReadLine(), out number));

        while (number > 0)
        {    result = number % 16;
            number = number / 16;
            
            switch (result)
            {
                case 10: stringBuild.Append('A'); break;
                case 11: stringBuild.Append('B'); break;
                case 12: stringBuild.Append('C'); break;
                case 13: stringBuild.Append('D'); break;
                case 14: stringBuild.Append('E'); break;
                case 15: stringBuild.Append('F'); break;
                case 16: stringBuild.Append('G'); break;
                default:
                    stringBuild.Append(result);
                    break;
            }
           
        }

        Print(stringBuild);
       
    }

    private static void Print(StringBuilder stringBuild)
    {
        for (int i = stringBuild.Length - 1; i >= 0; i--)
        {
            Console.Write(stringBuild[i]);
        }
        Console.WriteLine();
    }
}

