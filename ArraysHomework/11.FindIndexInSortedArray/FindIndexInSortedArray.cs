using System;
//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).

class FindIndexInSortedArray
{
    static void Main()
    {
        Console.WriteLine("How many cells your array to be: \nNot more than 20 recommended:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random myRand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = myRand.Next(-50, 200);
        }

        Array.Sort(array);
        Console.WriteLine("This is the array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Now enter the element which index you search for: ");
        int key = int.Parse(Console.ReadLine());
        int high = array.Length - 1;
        int low = 0;
        int currentIndex = (high + low) / 2;

        while (low <= high)
        {
            currentIndex = (high + low) / 2;

            if (key == array[currentIndex])
            {
                Console.WriteLine("The index of the key {0} is {1}", key, currentIndex);
                break;
            }
            else if (key > array[currentIndex])
            {
                low = currentIndex + 1;
            }
            else if (key < array[currentIndex])
            {
                high = currentIndex - 1;
            }
        }
    }
}

