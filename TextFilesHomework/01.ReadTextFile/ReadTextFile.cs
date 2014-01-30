using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

    class ReadTextFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Text.txt");
            string fileContent = string.Empty;
            int counter = 1;
            while (fileContent != null)
            {
                fileContent = reader.ReadLine();
                if (counter % 2 != 0)
                {
                    Console.WriteLine(fileContent);
                    
                }
                counter++;

            }
            reader.Close();
        }
    }

