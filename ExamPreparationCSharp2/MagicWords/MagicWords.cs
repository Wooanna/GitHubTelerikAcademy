using System;
using System.Collections.Generic;
using System.Text;

namespace MagicWords
{
    class MagicWods
    {
        static void Main()
        {
            List<string> words = new List<string>();

            int wordsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < wordsCount; i++)
            {
                words.Add(Console.ReadLine());
            }

            ReorderWords(words);
            
        }

        private static void ReorderWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                int position = words[i].Length % (words.Count + 1);
                words.Insert(position, words[i]);
                if (i <= position)
                {
                    words.RemoveAt(i);

                }
                else if (i > position) 
                {
                    words.RemoveAt(i + 1);
                }
                
            }
            int maxLength = 0;
            foreach (var word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                }
               // Console.WriteLine(word);
            }

            Print(words, maxLength);
            
        }

        private static void Print(List<string> words, int maxLength)
        {
            StringBuilder result = new StringBuilder();
            

            
                for (int i = 0; i < maxLength; i++)
                {
                    for (int k = 0; k < words.Count; k++)
                    {
                        if (i < words[k].Length)
                        {
                            result.Append(words[k][i]);
                        }
                        
                    }
                }

                Console.WriteLine(result);
                
           
        }
    }
}
