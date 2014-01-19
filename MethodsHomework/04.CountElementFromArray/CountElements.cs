using System;
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

class CountElementFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random myRand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = myRand.Next(0, 9);
        }
        PrintArray(array);
        Console.Write("Enter a number to be counted: ");
        Count(array);

    }

    private static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length && i != 0)
            {
                Console.Write(", ");
                
            } Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    private static void Count(int[] arr)
    {
        int searchedNumber = int.Parse(Console.ReadLine());
        int counter = 0;
        
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == searchedNumber)
                {
                    counter++;
                }
            }
       
        Console.WriteLine(counter);
    }

}

