using System;
using System.IO;
using System.Text;
//Write a program that concatenates two text files into another text file.

class ConcatenateTwoFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader("Textfile.txt");
        StreamReader readerTwo = new StreamReader("Text.txt");
        StringBuilder concatenatedText = new StringBuilder();
        using (readerTwo)
        {
            concatenatedText.Append(readerTwo.ReadToEnd());
            concatenatedText.Append(Environment.NewLine);
        }
        using (reader)
        {
            concatenatedText.Append(reader.ReadToEnd());
        }

        StreamWriter writer = new StreamWriter("finalText.txt");
        using (writer)
        {
            writer.WriteLine(concatenatedText);
        }
    }
}

