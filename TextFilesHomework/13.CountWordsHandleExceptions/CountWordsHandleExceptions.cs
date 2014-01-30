using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//Write a program that reads a list of words from a file words.txt and finds how many times each of the words 
//is contained in another file test.txt. The result should be written in the file result.txt 
//and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.

class CountWordsHandleExceptions
{
    static void Main()
    {
        StreamReader reader = new StreamReader("test.txt");
        StreamWriter writer = new StreamWriter("result.txt");
        string wholeText = string.Empty;

        using (reader)
        {
            wholeText = reader.ReadToEnd();
        }

        string[] separatedWords = wholeText.Split(new char[] { ' ', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);

        StreamReader read = new StreamReader("words.txt");
        string words = string.Empty;
        using (read)
        {
            words = read.ReadToEnd();
        }
        string[] searchedWords = words.Split(new char[] { ' ', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);

        int counter = 0;
        string currentWord = string.Empty;

        for (int i = 0; i < searchedWords.Length; i++)
        {
            for (int j = 0; j < separatedWords.Length; j++)
            {
                if (separatedWords[j] == searchedWords[i])
                {
                    currentWord = searchedWords[i];
                    counter++;
                }

            }

            string newRow = currentWord + " " + counter;
            counter = 0;
            writer.WriteLine(newRow);

        }
        writer.Close();
    }
}

