using System;
using System.Collections;
using System.Collections.Generic;
//Sort an array with the Merge sort algorithm 

class MergeSortAlgorithm
{

    static void Main()
    {
        Console.WriteLine("How long you array will be?: ");
        int n = int.Parse(Console.ReadLine());

        List<int> array = new List<int>();
        Random myRand = new Random();
        Console.WriteLine("This is the unsorted array: ");
        for (int i = 0; i < n; i++)
        {
            array.Add(myRand.Next(-30, 31));
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        int[] sorted = MergeSort(array).ToArray();
        Console.WriteLine(string.Join(", ", sorted));
    }

    private static List<int> MergeSort(List<int> arr)
    {
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        if (arr.Count <= 1)
        {
            return arr;
        }
        else
        {
            int middle = arr.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(arr[i]);
            }
            for (int i = middle; i < arr.Count; i++)
            {
                right.Add(arr[i]);
            }
        }

        left = MergeSort(left);
        right = MergeSort(right);

        return MergeArrays(left, right);
    }

    private static List<int> MergeArrays(List<int> left, List<int> right)
    {
        List<int> merged = new List<int>();

        int leftPointer = 0;
        int rightPointer = 0;

        while (leftPointer < left.Count || rightPointer < right.Count)
        {
            if (leftPointer < left.Count && rightPointer < right.Count)
            {
                if (left[leftPointer] <= right[rightPointer])
                {
                    merged.Add(left[leftPointer]);
                    leftPointer++;
                }
                else
                {
                    merged.Add(right[rightPointer]);
                    rightPointer++;
                }
            }

            if (leftPointer == left.Count && rightPointer < right.Count)
            {
                merged.Add(right[rightPointer]);
                rightPointer++;
            }
            else if (rightPointer == right.Count && leftPointer < left.Count)
            {
                merged.Add(left[leftPointer]);
                leftPointer++;
            }
        }
        return merged;
    }
}

