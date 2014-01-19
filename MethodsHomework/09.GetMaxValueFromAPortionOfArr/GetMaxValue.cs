using System;
//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

class GetMaxValueFromAPortionOfArr
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many cells your array has:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random myRand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = myRand.Next(0, 50);
        }
        PrintSortedArray(array);
        FindMax(array);
        Sort(array);
    }

    private static int[] Sort(int[] array)
    {
        char choise;
        do
        {
            Console.WriteLine("Please enter D dordescending or A for ascending way of sorting: ");

            choise = char.Parse(Console.ReadLine());

        } while (!(choise == 'D' || choise == 'A'));

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)  //compare [j] with [j-1] if [j] > [j-1] put [j] in min, than put [j-1] in [j], than put min in [j-1];
            {
                if (choise == 'A')
                {
                    if (array[j] < array[i])
                    {

                        int min = array[j];
                        array[j] = array[i];
                        array[i] = min;

                    }
                }
                else
                {
                    if (array[j] > array[i])
                    {
                        int max = array[j];
                        array[j] = array[i];
                        array[i] = max;
                    }
                }
            }
        }

        PrintSortedArray(array);
        return array;
    }

    private static void PrintSortedArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1) Console.Write(",");
        }
        Console.WriteLine();
    }

    private static int FindMax(int[] array)
    {
        Console.WriteLine("Which cell to be starting point for looking for the greater element in the array: ");
        int indexStart;
        do
        {
          indexStart = int.Parse(Console.ReadLine());
        } while (indexStart < 0 && indexStart > array.Length - 1);
        int max = int.MinValue;

        for (int i = indexStart; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine(max);
        return max;
    }
}
