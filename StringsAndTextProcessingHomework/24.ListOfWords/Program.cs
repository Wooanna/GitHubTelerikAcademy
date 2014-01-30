using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of words,
//separated by spaces and prints the list in an alphabetical order.


class ListOfWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        List<string> words = new List<string>();
        words = text.Split(new char[] { ' ' }).ToList();
        words.Sort();
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

