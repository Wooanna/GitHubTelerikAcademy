using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CsharpBrackets
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        string formattingString = Console.ReadLine();
        List<string> codeLines = new List<string>();
        for (int i = 0; i < lines; i++)
        {
            string inputLine = Console.ReadLine();
            codeLines.Add(Regex.Replace(inputLine.TrimStart(), " +", " "));
        }
        FormattingCode(codeLines, formattingString);

    }

    private static void FormattingCode(List<string> code, string formattingString)
    {
        List<string> formattedCode = new List<string>();
        StringBuilder AddingformattingString = new StringBuilder();
        StringBuilder CurrentLine = new StringBuilder();

        foreach (var line in code)
        {
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] == '{')
                {
                    if (CurrentLine.Length > 0)
                    {
                        formattedCode.Add(AddingformattingString + CurrentLine.ToString().Trim());
                        CurrentLine.Clear();
                    }

                    formattedCode.Add(AddingformattingString + "{");
                    AddingformattingString.Append(formattingString);
                }
                else if (line[j] == '}')
                {
                    if (CurrentLine.Length > 0)
                    {
                        formattedCode.Add(AddingformattingString + CurrentLine.ToString().Trim());
                        CurrentLine.Clear();

                    }
                    AddingformattingString.Remove(AddingformattingString.Length - formattingString.Length, formattingString.Length);
                    formattedCode.Add(AddingformattingString + "}");
                }
                else if (line[j] != '}' && line[j] != '{')
                {
                    CurrentLine.Append(line[j]);
                }
                 if (j == line.Length - 1 && CurrentLine.Length > 0)
                {
                    formattedCode.Add(AddingformattingString + CurrentLine.ToString().Trim());
                    CurrentLine.Clear();
                }
            }
        }
        PrintFinalResult(formattedCode);
    }

    private static void PrintFinalResult(List<string> formattedCode)
    {
        foreach (var line in formattedCode)
        {
            Console.WriteLine(line);
        }
    }
}

