using System;
using System.Collections.Generic;
//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
//n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

class Permutations
{
    static int n = 1;
    static void Main(string[] args)
    {
        //N = int.Parse(Console.ReadLine());
        int[] permutations = new int[n];
        bool[] isUsed = new bool[n + 1];

        GeneratePermutations(n - 1, permutations, isUsed);
    }

    static void GeneratePermutations(int index, int[] permutations, bool[] isUsed)
    {
        if (index < 0)
        {
            Print(permutations);
        }
        else
        {
            for (int i = n; i >= 0; i--)
            {
                if (isUsed[i])
                {
                    continue;
                }
               
                permutations[index] = i;
                isUsed[i] = true;
                GeneratePermutations(index - 1, permutations, isUsed);
                isUsed[i] = false;
            }
        }
    }

    static void Print(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}

