using System;
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaxSquareInMatrix
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8]
        {
            {8,2,1,3,4,5,1,2},
            {-3,5,4,2,3,7,3,3},
            {0,2,9,4,5,9,7,9},
            {-2,3,6,5,7,9,9,9},
            {-3,0,2,5,6,9,9,9},
            {2,4,5,9,5,2,1,1},
            {1,1,1,1,1,1,1,1},
            {9,4,-2,3,4,5,5,5}

            //{1,0,0,0,0,3,0,0},
            //{0,0,0,0,0,0,0,0},
            //{0,0,0,0,0,0,0,0},
            //{0,0,0,0,0,0,0,0},
            //{0,0,0,0,0,0,0,0},
            //{0,0,0,0,0,0,0,0},
            //{0,0,0,0,0,0,0,0},
            //{0,0,0,0,0,0,0,0},
        };

        //print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        FindMaxSquare(matrix);

        //print result 
        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
                Console.Write("{0, -4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int bestCol = 0;
    static int bestRow = 0;
    private static void FindMaxSquare(int[,] matrix)
    {
        int[,] bestPlatform = new int[3, 3];
        int maxSum = int.MinValue;
        //int sum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                // int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                //    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                //    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                int sum = 0;

                for (int i = row; i <= row + 2; i++)
                {
                    for (int j = col; j <= col + 2; j++)
                    {
                        sum += matrix[i, j];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;

                    bestCol = col;
                    bestRow = row;
                }
            }
        }
    }
}




