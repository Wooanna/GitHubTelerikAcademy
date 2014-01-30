using System;
using System.Text;


class ConsoleJustification
{
    private static StringBuilder wholeText = new StringBuilder();
    private static int numberOfRows;
    private static int lengthOfEachRow;

    static void Main()
    {
        numberOfRows = int.Parse(Console.ReadLine());
        lengthOfEachRow = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfRows; i++)
        {
            string singleRow = Console.ReadLine();
            for (int j = 0; j < singleRow.Length; j++)
            {

                if (j < singleRow.Length - 2 && j > 0 && singleRow[j] == ' ' && singleRow[j - 1] != ' ')
                {
                    wholeText.Append(singleRow[j]);
                }
                else if (char.IsLetter(singleRow[j]))
                {
                    wholeText.Append(singleRow[j]);

                }

            }

            wholeText.Append(" ");

        }

       
        SeparateEachLine();
    }

    private static void SeparateEachLine()
    {
        StringBuilder currentLine = new StringBuilder();
        StringBuilder currWord = new StringBuilder();
        for (int i = 0; i < wholeText.Length; i++)
        {

            if (wholeText[i] == ' ')
            {

                if (currentLine.Length + currWord.Length <= lengthOfEachRow)
                {
                    currentLine.Append(currWord);
                    currWord.Clear();

                }
                else if (currentLine.Length + currWord.Length > lengthOfEachRow)
                {
                    string temp = currentLine.ToString().TrimStart();
                    currentLine.Clear();
                    currentLine.Append(temp);


                    if (!currentLine.ToString().Contains(" "))
                    {
                        Console.WriteLine(currentLine);
                        currentLine.Clear();
                        string tempWord = currWord.ToString().Trim();
                        currWord.Clear();
                        currWord.Append(tempWord);

                    }
                    else
                    {
                        while (true)
                        {
                            if (currentLine.Length == lengthOfEachRow || currentLine.Length == 0)
                            {
                                break;
                            }
                            for (int p = 0; p < currentLine.Length; p++)
                            {
                                if (currentLine.ToString().Contains(" "))
                                {
                                    if (currentLine[p] == ' ')
                                    {
                                        if (currentLine.Length != lengthOfEachRow)
                                        {
                                            currentLine.Insert(p, ' ');
                                            p++;

                                        }
                                    }
                                }
                            }
                        }

                    }


                    if (currentLine.Length == lengthOfEachRow)
                    {
                        Console.WriteLine(currentLine);
                        currentLine.Clear();
                        i = i - currWord.Length;
                        i++;
                        currWord.Clear();
                    }

                }

                if (currentLine.Length == lengthOfEachRow)
                {
                    Console.WriteLine(currentLine);
                    currentLine.Clear();
                    currWord.Clear();
                    i = i - currWord.Length;
                    i++;
                }
            }
            currWord.Append(wholeText[i]);

        }
        Console.WriteLine(currentLine);

    }


}

