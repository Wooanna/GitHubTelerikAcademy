using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

class FindSubsetSum
{
    static void Main()
    {

        int[] myArray = new int[8] { 2, 4, 1, 8, 4, 3, -1, 3 };

        Console.WriteLine(String.Join(", ", myArray));
        Console.WriteLine();
         uint sequenceLength;
        do
        {
            Console.WriteLine("How long the longest sequence will be? (in the range [0-8] inclusively)");
        } while (!uint.TryParse(Console.ReadLine(), out sequenceLength));

        uint sum;
        do
        {
            Console.WriteLine("What is the sum you look for? ");
        } while (!uint.TryParse(Console.ReadLine(), out sum));

        for (int i = 0; i < myArray.Length - sequenceLength; i++)
        {
            int temp = 0;
            for (int j = i; j < i+sequenceLength; j++)
            {
                temp += myArray[j];
                if (temp == sum)
                {
                    Console.WriteLine("Sequence equal to {0} found:", sum);
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write("{0} ", myArray[k]);
                    }
                    Console.WriteLine();
                }
            }
        }

       



       







    }


}

