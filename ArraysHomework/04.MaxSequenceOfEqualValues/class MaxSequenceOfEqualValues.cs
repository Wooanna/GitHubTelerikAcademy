using System;

//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class MaxSequenceOfEqualValues
{
    static void Main()
    {
        Console.WriteLine("How long your array will be?");
        int N = int.Parse(Console.ReadLine());
        Random myRand = new Random();

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {

            array[i] = myRand.Next(0, 5);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int lenghtCounter = 1;     
        int digit = 0;
        int greatestLenght = 0;

        for (int i = 1; i < N; i++)
        {
            
            if (array[i] == array[i - 1])
            {
                lenghtCounter++; 
                digit = array[i];
            }
            if (array[i] != array[i - 1])
            {
                if (lenghtCounter > greatestLenght)
                {
                    greatestLenght = lenghtCounter;
                    lenghtCounter = 1;
                }
            }
        }
        if (lenghtCounter > greatestLenght)
        {
            greatestLenght = lenghtCounter;
        }
        Console.WriteLine("The longest sequence is {0} digits long.\nAnd it is of '{1}'s.", greatestLenght, digit);
    }
}

