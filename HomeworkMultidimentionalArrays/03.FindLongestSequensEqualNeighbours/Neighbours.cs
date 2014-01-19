using System;
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
class Neighbours
{
    static int longestSequence = 0;
    static int currentSequenceLength = 0;
    static string currentElement = string.Empty;
    static string bestElement = string.Empty;
    static void Main()
    {
        string[,] matrix = new string[5, 5]    
        {
                  {"ko?Ne","koi?","HoHo!","kak?","Ko rechi?"},
                  {"aaaa!","HoHo!","hihi",":D","Oi!Oi!"},
                  {"HoHo!","cc","ko?Ne","eeeee!","eeeee!"},
                  {"aaaa!","tt","ko?","ko?Ne","aaaaa!"},
                  {"aaaa!","ko?","aaaa!","Ne!","ko?Ne"},
            };

        Print(matrix);

        bool[,] isChecked = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (isChecked[row, col] == false)
                {
                    currentSequenceLength = 0;
                    currentElement = matrix[row, col];
                    FindMaxSequence(row, col, matrix, isChecked,  matrix[row, col]);
                    if (longestSequence< currentSequenceLength)
                    {
                        longestSequence = currentSequenceLength;
                        bestElement = matrix[row, col];
                    }
                }
            }
        }

        Console.WriteLine("The longest sequence of equal strings is {0} elements long and it says \'{1}'", longestSequence, bestElement);        
    }

    private static void FindMaxSequence(int row, int col, string[,] matrix, bool[,] isChecked, string bestElement)
    {
        if (row < 0 || row>= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
        {
            return;
        }
        if (isChecked[row, col] == true)
        {
            return;
        }

        if (matrix[row, col] == currentElement)
        {
            currentSequenceLength++;
            isChecked[row, col] = true;
        }
        else { return; }

        FindMaxSequence(row + 1, col, matrix, isChecked, bestElement);
        FindMaxSequence(row, col + 1, matrix, isChecked, bestElement);
        FindMaxSequence(row + 1, col + 1, matrix, isChecked, bestElement);
        FindMaxSequence(row + 1, col - 1, matrix, isChecked, bestElement);

    }

    private static void Print(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, -7}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

