using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class MovingLetters
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            string input = Console.ReadLine();

            List<string> words = new List<string>();
            StringBuilder word = new StringBuilder();
            StringBuilder sequenceOfLetters = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    word.Append(input[i]);
                }
                else
                {
                    words.Add(word.ToString());
                    word.Clear();
                }

            }
            words.Add(word.ToString()); //add the last word to the list, in case we have no ' ' char.
            word.Clear();

            int lettersCount = 0; //all letters count
            for (int i = 0; i < words.Count; i++)
            {
                lettersCount += words[i].Length;
            }

            int index = 0; //helper for indexing the letters of the words

            while (sequenceOfLetters.Length != lettersCount)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    sequenceOfLetters.Append(ConvertWordsToASequeneOfLetters(words[i], words[i].Length - (index + 1)));
                }
                index++;
            }

            MovingLetter(sequenceOfLetters);
        }

        private static string ConvertWordsToASequeneOfLetters(string word, int counter)
        {
            if (counter >= 0)
            {
                char currentLetter = word[counter];
                return currentLetter.ToString();
            }
            else
            {
                return "";//returns "" when we have no letter left in the current word
            }
        }

        private static StringBuilder MovingLetter(StringBuilder sequenceOfLetters)
        {
            
            int index = 0;
            int listLength = sequenceOfLetters.Length;
            char currentChar;
            //moving letters
            for (int i = 0; i < sequenceOfLetters.Length; i++)
            {
                 currentChar = sequenceOfLetters[i];
                 if (char.IsLower(sequenceOfLetters[i]))
                 {
                     index = sequenceOfLetters[i] - 'a' + 1;
                 }
                 else 
                 {
                     index = sequenceOfLetters[i] - 'A' + 1;
                 }
	
                 sequenceOfLetters.Remove(i, 1);  //remove the char

                 index += i;

                 index = index % listLength;

                sequenceOfLetters.Insert(index, currentChar);

            }
            Console.WriteLine(sequenceOfLetters);
            return sequenceOfLetters;
        }
    }
}
