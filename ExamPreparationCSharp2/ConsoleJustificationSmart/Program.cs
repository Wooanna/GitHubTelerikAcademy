using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ConsoleJustificationSmart
{
    static void Main(string[] args)
    {
        int countOfLines = int.Parse(Console.ReadLine());
        int charsPerLine = int.Parse(Console.ReadLine());
        List<string> separatedWords = new List<string>();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < countOfLines; i++)
        {
            string line = Console.ReadLine();
            foreach (var item in SplitLines(line))
            {
                separatedWords.Add(item);
            }

        }

        int next = 0;
        int startRow = 0;
        int allWords = separatedWords.Count;
        int wordLength = separatedWords[next].Length;
        next++;

        StringBuilder print = new StringBuilder();

        do
        {
            if (wordLength + separatedWords[next].Length + 1 > charsPerLine)
            {
                print.AppendLine(Row(separatedWords, startRow, next - 1, wordLength, charsPerLine));
                startRow = next;
                wordLength = separatedWords[next].Length;
            }
            else
            {
                wordLength = wordLength + separatedWords[next].Length + 1;
            }

            if (next == allWords - 1)
            {
                print.AppendLine(Row(separatedWords, startRow, next, wordLength, charsPerLine));
            }
            next++;
        } while (next < allWords);

        Console.WriteLine(print);  
    }

    static List<string> SplitLines(string line)
    {
        List<string> words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        
        return words;
    }

    static string Row(List<string> separatedWords, int startRow, int next, int wordLength, int symbolsPerLine)
    {
        StringBuilder result = new StringBuilder();

        if (startRow == next)
        {
            result.Append(separatedWords[startRow]);
        }
        else
	{
            int spaces = (symbolsPerLine - wordLength) / (next - startRow);
            int spacesPlus = (symbolsPerLine - wordLength) % (next - startRow);

            for (int i = startRow; i <= next; i++)
            {
                result.Append(separatedWords[i]);

                if (i < next)
                {
                    for (int j = 0; j < spaces + 1; j++)
                    {
                        result.Append(' ');
                    }
                    if (spacesPlus > 0)
                    {
                        result.Append(' ');
                    }
                    spacesPlus--;
                }
            }

	}
        return result.ToString();

    }
}

