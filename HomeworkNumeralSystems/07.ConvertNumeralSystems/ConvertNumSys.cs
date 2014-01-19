using System;

class ConvertAnyToAnySystem
{
    static void Main()
    {
        
        Console.WriteLine(BaseSToBaseD("529", 8, 16));
      
    }

    static char GetChar(int i)
    {
        if (i >= 10)
        {
            return (char)('A' + i - 10);
        }

        else
        {
            return (char)('0' + i);
        }
    }

    static int GetNumber(string numberToConvert, int position)
    {
        if (numberToConvert[position] >= 'A')
        {
            return numberToConvert[position] - 'A' + 10;
        }
        else
        {
            return numberToConvert[position] - '0';
        }
    }

    static string Base10ToBaseD(int decimalNumber, int baseD)
    {
        string result = String.Empty;

        for (; decimalNumber != 0; decimalNumber /= baseD)
        {
            result = GetChar(decimalNumber % baseD) + result;
        }

        return result;
    }

    static int BaseSToBase10(string numberToConvert, int baseS)
    {
        int decimalNumber = 0;

        for (int position = numberToConvert.Length - 1, power = 1; position >= 0; position--, power *= baseS)
        {
            decimalNumber += GetNumber(numberToConvert, position) * power;
        }

        return decimalNumber;
    }

    static string BaseSToBaseD(string result, int baseS, int baseD)
    {
        return Base10ToBaseD(BaseSToBase10(result, baseS), baseD);
    }
}