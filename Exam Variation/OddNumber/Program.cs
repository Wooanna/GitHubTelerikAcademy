using System;

using System.Numerics;


namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger output = 0;
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            for (int i = 0; i < N - 1; i++)
            {
                BigInteger restOFinput = BigInteger.Parse(Console.ReadLine());
                output = input ^ restOFinput;
                input = output;
                
            }
            Console.WriteLine(output);
        }
       
    }
}
