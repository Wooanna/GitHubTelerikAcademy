using System;
using System.Text;

class BinaryToDecimal
{
    static void Main()
    {
        int result = 0;
        Console.WriteLine("Please enter binary representation of a number: ");
        string binaryNumber = Console.ReadLine();

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[i] == '1')
            {
                result += 1 * (int)Math.Pow(2, (binaryNumber.Length - i - 1));
            }
            else if (binaryNumber[i] != '1' && binaryNumber[i] != '0')
            {
                Console.WriteLine("Invalid binary representation");
                return;
            }
        }

        Console.WriteLine(result);
    }
}

 