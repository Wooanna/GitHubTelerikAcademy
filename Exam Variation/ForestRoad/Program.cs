using System;

class Forest
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[,] road = new int[N * 2 - 1, N];
        int currentRow = 0;
        int currentCol = 0;

        while (true)
        {
            road[currentRow, currentCol] = 1;
            
            currentRow++;
            if (currentRow < N)
            {
                currentCol++;
            }
            else { currentCol--;  }
            if (currentRow == N * 2 - 1)
            {
                break;
            }
        }
        //print
        for (int row = 0; row < (N * 2) - 1; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (road[row, col] == 0)
                {
                     Console.Write('.');
                }
                if (road[row, col] == 1)
                {
                    Console.Write('*');
                }
               

            }
            Console.WriteLine();
        }

    }
}

