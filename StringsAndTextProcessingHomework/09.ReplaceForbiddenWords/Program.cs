using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We are given a string containing a list of forbidden words
//and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

    class ReplaceWords
    {
        static void Main()        
        {
            StringBuilder text = new StringBuilder();
             text.Append("Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");
            string forbiddenWord = "PHP";
            string forbiddenWordTwo = "CLR";
            String forbiddenWordTree = "Microsoft";
            text.Replace(forbiddenWord, "***");
            text.Replace(forbiddenWordTwo, "***");
            text.Replace(forbiddenWordTree, "*********");

            Console.WriteLine(text);
        }
    }

