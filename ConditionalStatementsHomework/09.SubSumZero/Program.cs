using System;
//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8 ---> 1+1-2=0.

class SubsetSum
{
    static void Main()
    {
        int[] ints = new int[5];
        for (int i = 0; i < 5; i++)
        {
            ints[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j <  5; j++)
        {
           int IsZeroTwoCells  = ints[j] + ints[j+1];
           if (IsZeroTwoCells == 0)
           {
               Console.WriteLine("The sum of {0} and {1} is zero", ints[j], ints[j+1]);
           }
           int IsZeroThreeCells = ints[j] + ints[j + 1] + ints[j + 2];
           if (IsZeroThreeCells == 0)
           {
               Console.WriteLine("The sum of {0}, {1} and {2} is zero", ints[j], ints[j+1], ints[j + 2]);
           }
           int IsZeroFourCells = ints[j] + ints[j + 1] + ints[j + 2] + ints[j + 3];
           if (IsZeroFourCells == 0)
           {
               Console.WriteLine("The sum of {0}, {1}, {2} and {3} is zero", ints[j], ints[j + 1], ints[j + 2], ints[j + 3]);
           }
           int IsZeroFiveCells = ints[j] + ints[j + 1] + ints[j + 2] + ints[j + 3] + ints[j + 4];
           if (IsZeroFourCells == 0)
           {
               Console.WriteLine("The sum of {0}, {1}, {2} and {3} and {4} is zero", ints[j], ints[j + 1], ints[j + 2], ints[j + 3], ints[j + 4]);
           }

        }
    }
}

