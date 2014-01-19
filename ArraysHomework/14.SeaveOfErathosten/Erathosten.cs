using System;
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


class SeaveOfErathosten
{
    static void Main()
    {
        int n = 10000000;
        int[] array = new int[n + 1];

        bool[] isPrime = new bool[array.Length];
        for (int i = 0; i < isPrime.Length; i++)
        {
            isPrime[i] = true;
        }

        //solution
        for (int i = 2; i < Math.Sqrt(n); i++) // you should only do the algorithm to the sqrt of the greatest number in your sequence. Every search after this is useless.
        {
            int divider = i;
            for (int j = i * 2; j < array.Length; j += i) //there is a rule if your current devider is 2  that every second number will be out of the prime colection.
            {                                             //Than if its 3, every third number will be out. 
                if ((isPrime[j] == true) && (j % divider == 0) && (divider != j))
                {
                    isPrime[j] = false;
                }
            }
        }
        //print all prime numbers
        for (int i = 1; i < isPrime.Length; i++)
        {
            if (isPrime[i] == true)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}

