using System;
using System.Numerics;
//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

class CalculatingSum
{
    static void Main()
    {
        Console.Write("Enter number for N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for X (between 1 and 5 recommended:");
        int X = int.Parse(Console.ReadLine());
        BigInteger sum = 1;
        BigInteger nFactorial = 1;
        BigInteger XByN = 1;
        BigInteger nFactorialDevByXByN = 1;


        for (int k = 1; k <= N; k++)
        {
            nFactorial = nFactorial * k;
            XByN = X * k;
            nFactorialDevByXByN = nFactorial / XByN; 
             sum += nFactorialDevByXByN;
            
        }
        
        Console.WriteLine(sum);

    }
}

