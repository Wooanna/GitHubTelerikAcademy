using System;


class FindMaxSumInArray
{
    /*Write a program that finds the sequence of maximal sum in given array. Example:
   {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} Can you do it with only one loop 
     * (with single scan through the elements of the array)?
   */

    public static void Main() //lets create an array, to fill it up with random integers every time we start the program
    {
        int[] array = new int[8];
        Random random = new Random();
        //put the random generated values in the array
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 10);
        }

        Console.Write(String.Join(", ", array)); //print out the array
        Console.WriteLine();
        Console.WriteLine("Max sum is {0} ", maxSubsetSum(array)); // call the method and print out result
    }


    public static int maxSubsetSum(int[] array)
    {
        int tempSum = 0;
        int maxSum = 0;
        int tempSumStartIndex = 0;
        int maxSumStart = 0;
        int maxSumEnd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int futureSum = tempSum + array[i];
            if (futureSum > 0)
            {
                tempSum = futureSum;
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    maxSumStart = tempSumStartIndex;
                    maxSumEnd = i;
                }
            }
            else
            {
                tempSum = 0;
                tempSumStartIndex = i + 1;
            }
        }
        Console.WriteLine("MaxStarts at position: " + maxSumStart + "\nMax Ends at position:" + maxSumEnd);

        return maxSum;
    }
}

