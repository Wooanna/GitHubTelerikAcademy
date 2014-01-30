using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//Write a program that extracts from a given text all sentences containing given word.

class ExtractSentence
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
       

        foreach (Match sentence in Regex.Matches(text, @"\s*([^\.]*\b" + substring + @"\b.*?\.)"))
            Console.WriteLine(sentence.Groups[1]);

    }
}

