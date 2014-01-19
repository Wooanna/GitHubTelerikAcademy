using System;
//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

class FindingMajorant
{
    static void Main()
    {
        //fill up array wih some random generated nums 0 to 5
        int[] array = new int[8];

        Random myRand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = myRand.Next(2, 9);
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();

        //some helpfull variables
        int tempNumber = 0;
        int count = 0;
        int maxCount = 0;
        int maxFrequentNumber = 0;
        //solution loop   
        for (int i = 0; i < array.Length; i++)
        {
            tempNumber = array[i];
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == tempNumber)
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxFrequentNumber = tempNumber;
                    }
                }
            }

            count = 0;
        }

        Console.WriteLine("The most frequent number in the array is {0} with frequency of {1} ", maxFrequentNumber, maxCount);
    }
}

