using System;
using System.Numerics;
namespace Problem_5_Brackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int len = input.Length;
            BigInteger[,] matrix = new BigInteger[len + 1, len + 2];
            matrix[0, 0] = 1;
            for (int k = 1; k <= len; k++)
            {
                if (input[k - 1] == '(') matrix[k, 0] = 0;
                else matrix[k, 0] = matrix[k - 1, 1];
                for (int c = 1; c <= len; c++)
                {
                    if (input[k - 1] == '(') matrix[k, c] = matrix[k - 1, c - 1];
                    else if (input[k - 1] == ')') matrix[k, c] = matrix[k - 1, c + 1];
                    else matrix[k, c] = matrix[k - 1, c - 1] + matrix[k - 1, c + 1];
                }
            }
            Console.WriteLine(matrix[len, 0]);
        }
    }
}
