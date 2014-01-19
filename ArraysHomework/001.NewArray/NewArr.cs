using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

class NewArr
{
    static void Main()
    {
        int[] newArr = new int[20];

        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = i * 5;
            PrintNums(newArr, i);
        }
    }

    private static void PrintNums(int[] newArr, int i)
    {
        Console.Write("{0, 3}", newArr[i]);
        if ((i + 1) % 5 == 0)
        {
            Console.WriteLine();
        }
    }
}

