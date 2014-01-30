using System;
using System.IO;
using System.Text;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.


    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("Text.txt");
            StreamWriter writer = new StreamWriter("EditedText.txt"); 
            StringBuilder strings = new StringBuilder();
            string fileContent = string.Empty;
            int counter = 1;
            using (reader)
            {
                fileContent = reader.ReadLine();
                string numeredLine = "Line " + counter.ToString() + ":" + fileContent;
                strings.AppendLine(numeredLine);

                while (fileContent != null)
                {
                    fileContent = reader.ReadLine();
                    numeredLine = "Line " + counter.ToString() + ":" + fileContent;
                    strings.AppendLine(numeredLine);
                    counter++;
                }
            }

            using (writer)
            {
                writer.Write(strings.ToString());
            }

        }
    }

