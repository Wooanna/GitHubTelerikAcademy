using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//Write a program that extracts from given XML file all the text without the tags. 

    class TextFromXML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("XML.txt");
            string currentLine = string.Empty;
            StringBuilder Result = new StringBuilder();
            bool inTag = false;
            using (reader)
            {
                currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        

                        if (currentLine[i] == '<')
                        {
                            inTag = true;
                        }
                        if (!inTag)
                        {
                            Result.Append(currentLine[i]);
                        }
                        if (currentLine[i] == '>')
                        {
                            inTag = false;
                        }
                    }
                    currentLine = reader.ReadLine();
                }
                
            }
            Console.WriteLine(Result);


        }
    }

