using System;
//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.


namespace _06.FindMaximalSumSequence
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            Console.Write("How long the array will be: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("How long the sequence will be: ");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int maxSum = 0;
            int currSum = 0;
            string sequence = "";
            string maxSequence = "";

            //fill up matrix
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //solution
            for (int i = 0; i < n - k; i++)
            {
                for (int p = i + k ; p > i; p--)
                {
                    currSum += array[p];
                    sequence += array[p] + " ";
                }
                if (maxSum < currSum)
                {
                    maxSum = currSum;
                    maxSequence = sequence;
                }
                currSum = 0;
                sequence = ""; 
            }

            Console.WriteLine("The sequence we are looking for is: {0}", maxSequence);
        }
    }
}
