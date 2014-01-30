using System;
using System.IO;
//Write a program that reads a text file containing a square matrix of
//numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N. Each of the next N lines 
//contain N numbers separated by space. The output should be a single number in a separate text file.
//Example:
//4
//2 3 3 4
//0 2 3 4		----->	17
//3 7 1 2
//4 3 3 2

class MaxSum
{
    static void Main()
    {
        
        StreamReader reader = new StreamReader("matrix.txt");
        int n = int.Parse(reader.ReadLine());
        int[,] matrix = new int[n, n];
        string currentLine = string.Empty;
        
        for (int row = 0; row < n; row++)
			{
                currentLine = reader.ReadLine();
                string[] numbersInLine = currentLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(numbersInLine[col]);
                }
            }
        FindMaxSum(matrix);

    }

    private static void FindMaxSum(int[,] matrix)
    {
        int rightmostStart = matrix.GetLength(0) - 1;
        int downmostStart = matrix.GetLength(1) - 1;
        int maxSum = int.MinValue;

        for (int row = 0; row < downmostStart; row++)
        {
            for (int col = 0; col < rightmostStart; col++)
            {
                int sum = 0;
                
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        sum += matrix[row + i, col + j];
                    }
                }
                
                if (sum >= maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}

