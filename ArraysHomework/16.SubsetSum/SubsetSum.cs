using System;

class SubsetSum
{
    //* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
    // arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

    //dynamic programming solution
    //data input
    static int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
    static int sum = 14;
    //declare a boolean 2-dim array to fill in all possible sums
    static bool[,] func = new bool[arr.Length, sum + 1];
    static bool[,] isCalculated = new bool[arr.Length, sum + 1];

    private static void Main()
    {
        bool possibleSum = CalcFunc(arr.Length - 1, sum);
        Console.WriteLine(possibleSum);
        int i = arr.Length - 1;
        while (true)
        {
            if (CalcFunc(i-1, sum - arr[i]))
            { 
                Console.Write(arr[i] + " ");
                sum = sum - arr[i];
                i = i - 1;
            }
            else if (CalcFunc(i-1, sum))
            {
                i = i - 1;
            }
            else if (arr[i] == sum)
            {
                Console.Write(arr[i] + " ");
                return;
            }
            if (sum == 0)
            {
                return;
            }
        }
    }

    static bool CalcFunc(int i, int sum)
    {
        if (sum < 0)
        {
            return false;
        }
        if (i < 0)
        {
            return false;
        }

        if (isCalculated[i, sum])
        {
            return func[i, sum];
        }
        
        func[i, sum] = arr[i] == sum || CalcFunc(i - 1, sum) || CalcFunc(i - 1, sum - arr[i]);

        isCalculated[i, sum] = true;
        return func[i, sum];

    }
}