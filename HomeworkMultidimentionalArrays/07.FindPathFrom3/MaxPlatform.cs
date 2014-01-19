using System;
using System.Collections;
using System.Collections.Generic;
//Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size

class FindMaxPlatform
{
    //original test
    static int[,] platform = 
        {
        {0,3,0,0,0,0},
        {3,3,3,0,0,0},
        {0,3,0,0,3,3},
        {0,3,0,3,3,0},
        {0,3,3,3,0,0},
        };

    //tests
    //static int[,] platform = 
    //    {
    //    {1,3,0,0,2,1},
    //    {1,3,3,1,1,1},
    //    {1,3,0,1,3,3},
    //    {1,1,1,1,3,0},
    //    {1,1,3,3,0,0},
    //    };

    //static int[,] platform = 
    //    {
    //    {4,4,0,0,0,0},
    //    {4,4,3,7,7,7},
    //    {0,3,0,0,3,3},
    //    {0,3,0,4,4,0},
    //    {0,3,3,4,0,0},
    //    };

    //static int[,] platform = 
    //    {
    //    {7,3,0,0,0,0},
    //    {7,7,7,7,7,7},
    //    {0,3,0,0,3,3},
    //    {0,3,0,3,3,0},
    //    {0,3,3,3,0,0},
    //    };

    //static int[,] platform = 
    //    {
    //    {9,9,9,9,9,9},
    //    {9,9,9,9,9,9},
    //    {9,9,9,9,9,0},
    //    {9,9,9,9,9,9},
    //    {9,9,9,9,9,9},
    //    };

    static bool[,] isChecked = new bool[platform.GetLength(0), platform.GetLength(1)];//mark if a given cell is checked(already visited) or not.
    static int counter = 0; // holds the count of the current digit we are checking now
    static int bestCount = 0; //holds the best count for the moment, in the end it has the best count 
    static int lastElement = 0; //holds the current element we are checking for
    static int bestElement = 0; //holds the element that has most counts

    static void Main()
    {
        Print(platform);
        for (int row = 0; row < platform.GetLength(0); row++)
        {
            for (int col = 0; col < platform.GetLength(1); col++)
            {
                if (isChecked[row, col] == false)
                {
                    lastElement = platform[row, col];

                    counter = 0;
                    FindMAxPlatform(row, col, isChecked, platform, platform[row, col]);
                    if (counter > bestCount)
                    {
                        bestCount = counter;
                        bestElement = platform[row, col];
                    }
                }
            }
        }

        Console.WriteLine("Count {0}", bestCount);
        Console.WriteLine("Digit {0}", bestElement);
    }

    static void FindMAxPlatform(int row, int col, bool[,] isChecked, int[,] platform, int lastElement)
    {
        if (row < 0 || row >= platform.GetLength(0) || col < 0 || col >= platform.GetLength(1))
        {
            return;
        }
        if (isChecked[row, col] == true)
        {
            return;
        }

        if (platform[row, col] == lastElement)
        {
            counter++;
            isChecked[row, col] = true;
        }
        else
        {
            return;
        }

        FindMAxPlatform(row + 1, col, isChecked, platform, platform[row, col]);
        FindMAxPlatform(row - 1, col, isChecked, platform, platform[row, col]);
        FindMAxPlatform(row, col + 1, isChecked, platform, platform[row, col]);
        FindMAxPlatform(row, col - 1, isChecked, platform, platform[row, col]);
    }

    static void Print(int[,] arr)
    { //print the labirynth
        for (int row = 0; row < platform.GetLength(0); row++)
        {
            for (int col = 0; col < platform.GetLength(1); col++)
            {
                Console.Write("{0, -3}", platform[row, col]);
            }
            Console.WriteLine();
        }
    }
}

