using System;
//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class GetMaxMethod
{
    static void Main(string[] args)
    {
        GetMax(5, -5);
    }

    private static int GetMax(int i, int j)
    {
        if (i < j)
        {
            Console.WriteLine(j);
            return j;
        }
        else
        {
            Console.WriteLine(i);
            return i;
        }
    }
}

