using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Write a program that replaces all occurrences of the substring "start"
// with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

class ReplaceSubstring
{
    static void Main()
    {
        StreamReader reader = new StreamReader("textFile.txt", Encoding.GetEncoding("Windows-1251"));
        StreamWriter writer = new StreamWriter("textFileReplace.txt");
        using (reader)
        {
            using (writer)
            {
                string currLine = reader.ReadLine();
                while (currLine != null)
                {
                    string replaced = currLine.Replace("start", "finish");
                    currLine = reader.ReadLine();
                    writer.WriteLine(replaced);
                }
            }
        }

        File.Delete("textFile.txt");
        File.Move("textFileReplace.txt", "textFile.txt");
        File.Delete("textFileReplace.txt");

    }

}

