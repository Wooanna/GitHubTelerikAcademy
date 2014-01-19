using System;


class Anacci
{
    static void Main()
    {
        char[] letter = new char[27] { ' ','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

       // int[] NUMBER = new int[26] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());

        int l = int.Parse(Console.ReadLine());
        int firstNum = Array.IndexOf(letter, firstLetter);
        int secNum = Array.IndexOf(letter, secondLetter);
        int nextNumGenerated = firstNum + secNum;
        int space = 0;

        Console.WriteLine(firstLetter);
        for (int i = 0; i < l-1; i++)
        {
            if (secNum > 26) secNum %= 26;
            if (nextNumGenerated > 26) nextNumGenerated = nextNumGenerated % 26;

            if (secNum == 0) secNum = 26;
            if (nextNumGenerated == 0) nextNumGenerated = 26;
            
            Console.Write(letter[secNum]);
            
            Console.Write(new string(' ', space));
            space++;

            
            Console.Write(letter[nextNumGenerated]);
            Console.WriteLine();

            secNum = secNum + nextNumGenerated;
            nextNumGenerated = secNum + nextNumGenerated;

            

            
        }

        }
    }


