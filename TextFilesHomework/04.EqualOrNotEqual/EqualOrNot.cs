using System;
using System.IO;
//Write a program that compares two text files line by line and prints the number 
//of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.


class EqualOrNot
{
    static void Main()
    {
        StreamReader readerOne = new StreamReader("textOne.txt");
        StreamReader readerTwo = new StreamReader("textTwo.txt");
        string currentLineOne = string.Empty;
        string currentLineTwo = string.Empty;
        int counter = 0;
        string numbersOfEqualRow = string.Empty;
        string numbersOfDifferentRows = string.Empty;
        currentLineOne = readerOne.ReadLine();
        currentLineTwo = readerTwo.ReadLine();

        while (currentLineOne != null)
        {

            counter++;
            if (currentLineOne == currentLineTwo)
            {
                numbersOfEqualRow += counter.ToString() + ' ';
            }
            else
            {
                numbersOfDifferentRows += counter.ToString() + ' '; 
            }
            currentLineOne = readerOne.ReadLine();
            currentLineTwo = readerTwo.ReadLine();

        }
        readerOne.Close();
        readerTwo.Close();
        Console.WriteLine("The equal  rows are {0}", numbersOfEqualRow);
        Console.WriteLine("The differ rows are {0}", numbersOfDifferentRows);
       
        

    }
}

