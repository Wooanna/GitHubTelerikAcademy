using System;
//Write a program that compares two char arrays lexicographically (letter by letter).



class CompareCharArrays
{
    static void Main()
    {
        char[] lettersOne = new char[10] { 'A', 'L', 'L', 'A', 'B', 'B', 'A', 'L', 'L', 'A' };
        char[] lettersTwo = new char[9] { 'P', 'O', 'L', 'T', 'O', 'K', 'A', 'L', 'A' };
        int minLength = Math.Min(lettersOne.Length, lettersTwo.Length);
        bool oneEqual = false;

        for (int i = 0; i <  minLength; i++)
        {
            if (lettersOne[i] == lettersTwo[i])
            {
                oneEqual = true;
                Console.WriteLine("The letters {1} are equal in position {0}. ", i, lettersTwo[i]);
            }   
        }

        if (!oneEqual)
        {
            Console.WriteLine("There are no equal characters!");
        }
    }
}

