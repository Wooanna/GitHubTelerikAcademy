using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a string from the console and prints 
//all different letters in the string 
//along with information how many times each letter is found.
namespace PrintAllDifferentLetters
{
    class Program
    {
        static void Main()
        {
            HashSet<char> letters = new HashSet<char>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                letters.Add(text[i]);
            }

            foreach (var item in letters)
            {
                int counter = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == item)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} - {1}", item, counter);
            }
        }
    }
}             
          
     
