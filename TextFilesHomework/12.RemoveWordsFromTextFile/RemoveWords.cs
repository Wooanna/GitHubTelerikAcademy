using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

class RemoveWordsFromTextFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader("words.txt");

        string[] searchedWords = reader.ReadToEnd().Split(new char[] { ' ', ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        reader.Close();
        StreamReader read = new StreamReader("text.txt");
        StringBuilder allWords = new StringBuilder();
        allWords.Append(read.ReadToEnd());

        for (int i = 0; i < searchedWords.Length; i++)
        {
            allWords = allWords.Replace(searchedWords[i], "REPLACED");
        }

        read.Close();

        StreamWriter writer = new StreamWriter("text.txt");
        writer.Write(allWords);
        writer.Close();




    }
}

