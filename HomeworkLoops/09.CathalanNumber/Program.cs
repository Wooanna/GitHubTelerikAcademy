using System;
using System.Numerics;
// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// Cn = (2n)! / (n + 1)! * n! for n>= 0;

    class CathalanNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger nFactorialByTwo = 1;
            BigInteger nFactorialPlusOne = 1;
            BigInteger dominator = 0;
            BigInteger nominator = 0;
            BigInteger nCathalan = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
            }

            for (int i = 1; i <= n*2; i++)
            {
                nFactorialByTwo = nFactorialByTwo * i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                nFactorialPlusOne = nFactorialPlusOne * i; 
            }

            dominator = nFactorialByTwo;
            nominator = nFactorialPlusOne * nFactorial ;
            nCathalan = dominator / nominator;

            Console.WriteLine(nFactorial);
            Console.WriteLine(nFactorialByTwo);
            Console.WriteLine(nFactorialPlusOne);
            Console.WriteLine(nCathalan);


        }
    }

