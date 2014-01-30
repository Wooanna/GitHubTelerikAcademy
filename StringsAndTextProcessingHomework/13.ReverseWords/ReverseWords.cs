using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class ReverseWords
{
    static void Main(string[] args)
    {



        string sentence = "C# is not C++, not PHP and not Delphi!";
        MatchCollection words = Regex.Matches(sentence, @"\b(?<word>[\w|\#\+]+)");
        MatchCollection signs = Regex.Matches(sentence, @"(,|!|\.|\?)");
        int mBound = words.Count;
        List<string> newSentence = new List<string>();
        int sign = 0;
        for (int i = 0; i < mBound; i++)
        {
            newSentence.Add(words[mBound - i - 1].ToString());
            if (signs.Count > sign && String.Join(" ", newSentence).Length >= signs[sign].Index)
            {
                newSentence[newSentence.Count - 1] += signs[sign].ToString();
                sign++;
            }
        }
        Console.WriteLine(String.Join(" ", newSentence));

    }
}

