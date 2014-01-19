using System;
using System.Numerics;
//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
class NandKFactorial
{
    static void Main()
    {

        BigInteger kFactorial = 1;
        BigInteger nFacottial = 1;
        int K;
        int N;

        do
        {
            K = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
        } while (N >= K);

        for (int i = 1; i <= K; i++)
        {
            kFactorial =  kFactorial * i;
        }

        for (int j = 1; j <= N; j++)
        {
            nFacottial = nFacottial * j;
        }
        
        BigInteger dominator = nFacottial * kFactorial;
        BigInteger nominator = (K - N); //factorial
        

        for (int y = 1; y <= K-N; y++)
        {
            nominator =  nominator * y;
        }


        BigInteger result = dominator / nominator;
        Console.WriteLine(result);





    }
}

