using System;
//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

class Alphabet
{
    static void Main()
    {
        char[] alphabet = new char[27];
        for (int i = 1; i < alphabet.Length ; i++) //put every letter at position equal to its position in the alphabet. Skip 0.
		{
            alphabet[i] = Convert.ToChar(i + 96);
		}

        Console.WriteLine();
        Console.WriteLine("Please enter word: ");
        string word = Console.ReadLine();
        Console.Write("The \"index\" representation of the word {0} is: ", word );
            
        //simply print every letter's index. 
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.Write("{0}, ", j);
                }
            }
        }
        Console.WriteLine();
    }
}

