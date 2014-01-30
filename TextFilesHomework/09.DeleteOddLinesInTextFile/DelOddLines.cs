using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DelOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("textLines.txt");

        string currentLine = string.Empty;
        List<string> oddLines = new List<string>();
        int counter = 1;

        using (reader)
        {
            currentLine = reader.ReadLine();
            while (currentLine != null)
            {

                if (counter % 2 == 0)
                {

                    oddLines.Add(currentLine);
                }
                currentLine = reader.ReadLine();
                counter++;
                
            }
        }

        reader.Close();
        StreamWriter writer = new StreamWriter("textLines.txt");

        using (writer)
        {
            foreach (var line in oddLines)
            {
                writer.WriteLine(line);
            } 
        }
        
    }
}

