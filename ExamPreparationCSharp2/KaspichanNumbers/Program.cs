using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;


class DurankulakNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] durankulakian = new string[168];
        for (int i = 0; i < 26; i++)
        {
            durankulakian[i] = ((char)(i + 65)).ToString();

        }
        for (int i = 26; i < 168; i++)
        {
            string dur = string.Empty;
            char lowerLetter = (char)((i / 26) + 96);
            char upperLetter = (char)((i % 26) + 65);
            dur =  "" + lowerLetter + upperLetter;
            durankulakian[i] = dur;
        }

        //for (int i = 0; i < durankulakian.Length; i++)
        //{
        //    Console.WriteLine(durankulakian[i]);
        //}
        StringBuilder durankulakianNumber = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                string currLetter = input[i].ToString();
                int currDigit = Array.IndexOf(durankulakian, currLetter);
                durankulakianNumber.Append(currDigit);
                durankulakianNumber.Append(' ');
            }
            else if (char.IsLower(input[i]) && i < input.Length - 1)
            {
                string currLetter = "" + input[i] + input[i + 1];
                i++;
                int currDigit = Array.IndexOf(durankulakian, currLetter);
                durankulakianNumber.Append(currDigit);
                durankulakianNumber.Append(' ');
            }
        }
        //Console.WriteLine(durankulakianNumber);
        string[] generatedNumbers = durankulakianNumber.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        BigInteger result = 0;
        for (int i = 0; i < generatedNumbers.Length; i++)
        {
            result = result + BigInteger.Parse(generatedNumbers[i]) * (BigInteger)(Math.Pow(168, generatedNumbers.Length - i- 1));
        }
        Console.WriteLine(result);
    }
}

