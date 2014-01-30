using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

class SortNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader("namesList.txt", Encoding.GetEncoding("Windows-1251"));
        StreamWriter writer = new StreamWriter("sortedNamesList.txt");
        List<string> names = new List<string>();
        string name = string.Empty;

        name = reader.ReadLine();
        names.Add(name);
        using (reader)
        {
            while (name != null)
            {
                name = reader.ReadLine();
                names.Add(name);
            }
        }

        names.Sort();

        using (writer)
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }

    }

}

