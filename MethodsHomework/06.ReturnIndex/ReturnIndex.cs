using System;
//Write a method that returns the index of the first element in array
//that is bigger than its neighbors, or -1,
//if there’s no such element.
//Use the method from the previous exercise.

class ReturnIndex
{
    static void Main()
    {
        Console.WriteLine("Please enter length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random myRand = new Random();
        for (int i = 0; i < n; i++)
        {
            array[i] = myRand.Next(0, 100);
        }
        Print(array);
        Console.WriteLine(Compare(array));
    }

    private static void Print(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    private static int Compare( int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i-1])
            {   
                return i; 
            }
        }
        return -1;
    }

}

