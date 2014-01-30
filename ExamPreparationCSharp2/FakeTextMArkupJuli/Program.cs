using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static string FormatText(string command, string input)
    {
        char[] charr;
        string result = "";
        switch (command)
        {
            case "":
                result = input;
                break;
            case "<upper>":
                result = input.ToUpper();
                break;
            case "<lower>":
                result = input.ToLower();
                break;
            case "<del>":
                result = "";
                break;
            case "<rev>":
                charr = input.ToCharArray();
                Array.Reverse(charr);
                result = new string(charr);
                break;
            case "<toggle>":
                charr = input.ToCharArray();
                for (int i = 0; i < charr.Length; i++)
                    if (char.IsLower(charr[i]))
                        charr[i] = char.ToUpper(charr[i]);
                    else if (char.IsUpper(charr[i]))
                        charr[i] = char.ToLower(charr[i]);
                result = new string(charr);
                break;
        }
        return result;
    }

    static string DoText(string command, string input)
    {
        while (input.Contains("<"))
        {
            int startCloseTag = input.IndexOf("</");
            int endCloseTag = startCloseTag + input.Substring(startCloseTag).IndexOf('>');
            string closeTag = input.Substring(startCloseTag, endCloseTag - startCloseTag + 1);
            string openTag = closeTag.Remove(1, 1);
            int startOpenTag = input.Substring(0, startCloseTag).LastIndexOf(openTag);
            int endOpenTag = startOpenTag + openTag.Length;
            string text = input.Substring(endOpenTag, startCloseTag - endOpenTag);
            text = FormatText(openTag, text);
            input = input.Substring(0, startOpenTag) + text + input.Substring(endCloseTag + 1);
        }
        return input;
    }

    static void Main()
    {
        int numLines = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numLines; i++)
        {
            if (i > 0)
                sb.Append(Environment.NewLine);
            sb.Append(Console.ReadLine());
        }
        Console.WriteLine(DoText("", sb.ToString()));
    }
}