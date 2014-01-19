using System;
//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class BinSearch
{
    static void Main(string[] args)
    {
        int length, K;
        do
        {
            Console.WriteLine("Please enter how long your array will be?");
        } while (!int.TryParse(Console.ReadLine(), out length));

        int[] myArray = new int[length];

        Random myRand = new Random();
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = myRand.Next(0, 10);
        }

        do
        {
            Console.WriteLine("Please enter value for K: ");

        } while (!int.TryParse(Console.ReadLine(), out K));

        Array.Sort(myArray);
        Console.WriteLine("The array: {0}", String.Join(", ", myArray));

        int maxLessThanK = int.MinValue;
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] > maxLessThanK && myArray[i] <= K)
            {
                maxLessThanK = myArray[i];
            }
        }

        int myResult = Array.BinarySearch(myArray, maxLessThanK);

        if (myResult < 0)
        {
            Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", maxLessThanK, myResult);
        }
        else
        {
            Console.WriteLine("The object to search for ({0}) is at index {1}.", maxLessThanK, myResult);
        }
    }
}

