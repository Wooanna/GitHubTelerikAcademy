using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FakeTextMarkup
{

    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        StringBuilder currLine = new StringBuilder();
        for (int i = 0; i < linesCount; i++)
        {
            currLine.Append(Console.ReadLine());
            SplitText(currLine);
            Console.WriteLine(currLine);

        }
    }

    private static string SplitText(StringBuilder currentLine)
    {

        string currentWord = string.Empty;
        string currentTag = string.Empty;
        int placement = 0;

        for (int i = 0; i < currentLine.Length; i++)
        {
            if (currentLine[i] == '/' && currentLine[i - 1] == '<')
            {
                GetAndRemoveTag(currentLine, i);
               
                
                for (int j = i - 2; j > 0; j--)
                {
                    if (currentLine[j] != '>') //take the word for the current operation
                    {
                        currentWord += currentLine[j];
                        currentLine.Remove(j, 1);

                    }
                    j--;
                    if (currentLine[j] == '>') 
                    {
                         placement = j;
                        currentTag = (GetTag(j, currentLine)); //get the tag for the current operation
                        currentLine.Insert(placement, DoFormatting(currentTag, currentWord, currentLine));
                        
                    }
                    
                }
            }

        }

        return currentLine.ToString();
    }

    private static string GetTag(int j, StringBuilder currentLine)
    {
        int startIndex = j;
        int endIndex = 0;
        string tag = string.Empty;
        for (int i = j; i >= 0; i--)
        {
            tag += currentLine[i];
            if (currentLine[i] == '<')
            {
                endIndex = i;
                break;
            }
            currentLine.Remove(startIndex - 1, endIndex - startIndex + 2);
        }
        return tag;
    }

    private static string DoFormatting(string currentTag, string currentWord, StringBuilder currentLine)
    {
        char[] a = currentTag.ToCharArray();
        Array.Reverse(a);
        currentTag = new string(a);

        char[] b = currentWord.ToCharArray();
        Array.Reverse(b);
        currentWord = new string(b);

        if (currentTag.ToLower() == "<rev>")
        {
            Reverse(currentWord);
        }
        else if (currentTag.ToLower() == "<del>")
        {

        }
        else if (currentTag.ToLower() == "<toggle>")
        {

        }
        else if (currentTag.ToLower() == "<upper>")
        {

        }
        else if (currentTag.ToLower() == "<lower>")
        {

        }
        return currentWord; // ?
    }

    private static void GetAndRemoveTag(StringBuilder currentLine, int i)
    {
        int startIndex = i;
        int endIndex = 0;
        for (int j = i; j < currentLine.Length; j++)
        {
            if (currentLine[j] == '>')
            {
                endIndex = j;
                break;
            }
        }
        currentLine.Remove(startIndex - 1, endIndex - startIndex + 2);
    }



    private static string Reverse(string currentWord)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = currentWord.Length - 1; i >= 0; i--)
        {
            reversed.Append(currentWord[i]);
        }
        return reversed.ToString();
    }

}










