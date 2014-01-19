using System;
using System.Text;
//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine(  Reverse(number));
    }

    private static string Reverse(decimal number)
    {
        string strNum = Convert.ToString(number);
        StringBuilder stringBiuld = new StringBuilder();

        for (int i = strNum.Length - 1; i >= 0; i --)
        {
            stringBiuld.Append(strNum[i]); 
        }
        return stringBiuld.ToString();
    }
}

