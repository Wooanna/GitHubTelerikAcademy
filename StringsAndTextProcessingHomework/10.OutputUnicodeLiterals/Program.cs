using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Use format strings. 

    class Unicode
    {
        static void Main()
        {
            Console.WriteLine("Please enter text:");
            string text = Console.ReadLine();
            StringBuilder unicodeSequence = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                string currentCharUnicode = "\\u00" + (int)(text[i] - 65);
                unicodeSequence.Append(currentCharUnicode);
            }
            Console.WriteLine(unicodeSequence);
        }
    }

