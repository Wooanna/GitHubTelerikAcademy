using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Modify the solution of the previous problem to replace only whole words (not substrings).


class Replace
{
    static void Main()
    {
        StreamReader reader = new StreamReader("TextFile.txt");
        StreamWriter writer = new StreamWriter("TextFile.txt");

        using (reader)
        using (writer)
        {
            string currLine = reader.ReadLine();
            while (currLine != null)
            {
                int start = 0;
                int index = currLine.IndexOf("start");
                StringBuilder line = new StringBuilder();

                if (index != -1)
                {
                    //while string start is present
                    while (index != -1)
                    {
                        //if "start" is a separate word, append line to it + finish and proceed with the rest of the line
                        if ((index > 0 && !char.IsLetter(currLine[index - 1]) || index == 0) &&
                            ((index + 5 <= currLine.Length - 1 && !char.IsLetter(currLine[index + 5])) || index + 5 > currLine.Length - 1))
                        {
                            for (int i = start; i < index; i++)
                            {
                                line.Append(currLine[i]);
                            }
                            line.Append("finish");
                            start = index + 5;
                        }
                        else
                        {
                            int counter = 0;
                            for (int i = start; i <= index + 4; i++)
                            {
                                line.Append(currLine[i]);
                                counter++;
                            }
                            start = start + counter;
                        }
                        index = currLine.IndexOf("start", start);
                        //if no more "start" substrings are found, append the rest of the line as is
                        if (index < 0 && start < currLine.Length)
                        {
                            for (int i = start; i < currLine.Length; i++)
                            {
                                line.Append(currLine[i]);
                            }
                        }
                    }
                    currLine = reader.ReadLine();
                    writer.WriteLine(line);
                }
            }
        }
    }
}

