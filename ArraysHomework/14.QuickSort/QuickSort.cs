using System;
using System.Collections.Generic;
//write a program that sorts a random array with the quick sort algorithm
class QuickSort
{
    static void Main()
    {
        List<int> myArray = new List<int> { 5, 2, -1, 4, 20, 8, 0, 1 };
        myArray = QuickSortAlg(myArray);
        Print(myArray);
    }

    private static void Print(List<int> myArray)
    {
        for (int i = 0; i < myArray.Count; i++)
        {
            Console.Write("{0, 3}", myArray[i]);
        }
        Console.WriteLine();
    }

    static List<int> QuickSortAlg(List<int> array)
    {
        if (array.Count <= 1) //base 
        {
            return array;
        }

        int pivotElem = array[0];
        int leftIndex = 1;
        int rightIndex = array.Count - 1;
        int leftElem = array[leftIndex];
        int rightElem = array[rightIndex];
        int swap = 0;
        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();

        while (leftIndex < rightIndex)
        {
            while (leftElem < pivotElem && leftIndex < array.Count)
            {
                leftList.Add(leftElem);
                leftIndex++;
                if (leftIndex < array.Count)
                {
                    leftElem = array[leftIndex];
                }
            }
            while (rightElem > pivotElem && rightElem != leftElem)
            {
                rightList.Add(rightElem);
                rightIndex--;
                rightElem = array[rightIndex];
            }
            if (leftElem > rightElem)
            {
                swap = array[rightIndex];
                array[rightIndex] = array[leftIndex];
                array[leftIndex] = swap;
                leftElem = array[leftIndex];
                rightElem = array[rightIndex];
            }
        }
        if (leftIndex == rightIndex)
        {
            swap = array[leftIndex - 1];
            array[leftIndex - 1] = pivotElem;
            array[0] = swap;
            if (array[leftIndex] < pivotElem) leftList.Add(array[leftIndex]);   //add last left element to the (left or right)list
            if (array[rightIndex] > pivotElem) rightList.Add(array[rightIndex]);
        }

        List<int> left = QuickSortAlg(leftList);
        List<int> right = QuickSortAlg(rightList);
        return Concat(left, pivotElem, right);
    }

    private static List<int> Concat(List<int> left, int pivot, List<int> right)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < left.Count; i++)
        {
            result.Add(left[i]);
        }
        result.Add(pivot);
        for (int i = 0; i < right.Count; i++)
        {
            result.Add(right[i]);
        }
        return result;
    }
}