using System;
//* Write a program that reads an array of integers and removes from it a minimal number of elements
//in such way that the remaining array is sorted in increasing order. 
//Print the remaining sorted array. Example:
	//{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

    class MaxSubsequence
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[]                   {5, 7, 2, 3, 1, 8, 10, 4, 14, 16};
            int[] sequence = new int[myArray.Length]; //{1, 2, 1, 2, 1, 3, 4,  3,  5,  6}; //for every element we hold how long the (searched) sequence is so far
            int[] tracking = new int[myArray.Length]; //here  we hold track for all the numbers in the increasing sequence
            int bestF = 0;
            int bestIndex = 0; //holds the index of the last element in the max sequence

            for (int i = 0; i < myArray.Length; i++)
            {
                sequence[i] = 1;  //every element starts a sequence. The sequence has at least 1 element.
                tracking[i] = int.MinValue; //all elements in tracking arr have int.minValue, so we can see the track of the maximal sequence and print it later
            }
            //solution
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j <= i -1 ; j++)
                {
                    if (myArray[j] < myArray[i])
                    {
                        if (sequence[j] + 1 > sequence[i])
                        {
                            sequence[i] = sequence[j] + 1;
                            tracking[i] = j;

                            if (sequence[i] > bestF)
                            {
                                bestF = sequence[i];
                                bestIndex = i;
                            }
                        }
                    }
                }
            }

            int index = bestIndex;
            //prints the extracted max increasing sequence , as it takes every the indexes of the numbers from the tracking array
            while (index != int.MinValue)
            {
                Console.Write(myArray[index] + " ");
                index = tracking[index];
            }
        }
    }

