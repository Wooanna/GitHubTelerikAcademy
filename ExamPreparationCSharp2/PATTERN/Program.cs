using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERN
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(str[j]);
                }
            }

            int maxSum = int.MinValue;

            int currRow = 0;
            int currCol = 0;

            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (matrix[currRow, currCol] == matrix[currRow, currCol + 1] + 1)
                        {
                            findMax(currRow, currCol, matrix);
                            currCol++;
                        }
                        

                    }
                    for (int j = 0; j < 2; j++)
                    {
                        if (matrix[currRow, currCol] == matrix[currRow + 1, currCol] + 1)
                        {
                            findMax(currRow, currCol, matrix);
                            currRow++;

                        }
                    }
                    for (int p = 0; p < 2; p++)
                    {
                        if (matrix[currRow, currCol] == matrix[currRow, currCol + 1] + 1)
                        {
                            findMax(currRow, currCol, matrix);
                        }
                        currCol++;

                    }
                    
                }
            }


        }

        private static void findMax(int row, int col, int[,] matrix)
        {

            if (row < 0 || row >= matrix.GetLength(0) - 2 || col < 0 || col >= matrix.GetLength(1) - 2)
            {
                return;
            }

            sum = sum + matrix[row, col];



        }
    }
}
