using System;
//Write a program that reads from the console a positive integer number N (N < 20)
//and outputs a matrix like the following:


namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int k = 1;
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = j + k;
                }
                k++;
            }

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0, -4}", matrix[i,j]); 
                }
                Console.WriteLine();
            }

        }
    }
}
