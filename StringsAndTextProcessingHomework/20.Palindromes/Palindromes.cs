using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that extracts from a given text all palindromes,
//e.g. "ABBA", "lamal", "exe".

    class Palindromes
    {
        static void Main()
        {
            string text = @"anna likes listen to  ABBA. mouseesuom";
            char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
            string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in splitted)
            {
                bool isPalindrome = true;
                for (int j = 0; j < (word.Length / 2); j++)
                {
                    if (word[j] != word[word.Length - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome && word.Length > 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }

