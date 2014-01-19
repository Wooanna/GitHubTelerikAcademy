using System;
//Write a method that checks if the element at given position in given array of integers is bigger
//than its two neighbors (when such exist).

class CompareElementsInAnArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter length of your array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random myRand = new Random();
        for (int i = 0; i < n; i++)
        {
            array[i] = myRand.Next(0, 100);
        }
        Print(array);
        int index;
        do
        {
            Console.WriteLine("Enter index:");
            index = int.Parse(Console.ReadLine());
        } while (index <= 0 || index >= array.Length - 1);

        Compare(array[index - 1], array[index], array[index + 1], array, index);
    }

    private static void Print(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    private static bool Compare(int left, int c, int right, int[] arr, int index)
    {
        if (left < c && right < c)
        {
            Console.WriteLine("The two elements to the left and to the right of your element are smaller.");
            return true;
        }
        if (left < c && right > c)
        {
            Console.WriteLine("The element on the left side of your element is smaller and the right is bigger");
        }
        if (left > c && right < c)
        {
            Console.WriteLine("The element on the left side of your element is bigger and the right is smaller");
        }

        else
        {
            Console.WriteLine("The two elements to the left and to the right of your element are bigger.");
            return false;
        }
        return false;
    }

}

