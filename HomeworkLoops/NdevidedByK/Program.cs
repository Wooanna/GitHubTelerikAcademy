using System;
using System.Numerics;
//Write a program that calculates N!/K! for given N and K (1<K<N).


    class NdevidedByK
    {
        static void Main()
        {
            int K;
            Console.Write("Enter a Greater number N: ");
            int N = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter a Lower number K: ");
                K = int.Parse(Console.ReadLine());
            } while (K >= N);
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger result;
            for (int i = 1; i <= N; i++)
            {


                nFactorial = nFactorial * i;
            }

            for (int i = 1; i <= K; i++)
            {
                kFactorial = kFactorial * i;
            }
            result = nFactorial / kFactorial;
            Console.WriteLine(result);
            
        }
    }

