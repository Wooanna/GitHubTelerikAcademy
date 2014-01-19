using System;


    class Lines
    {
        static void Main()
        {
            int[,] nNumbers = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
              int input  = int.Parse(Console.ReadLine());
              for (int j = 0; j < 8 ; j++)
              {
                  if ((input & (1 << j)) != 0)
                  {
                      nNumbers[i, j] = 1;
                  }
              }

            }

            
            int lineStart = 0;

            
            int[] count = new int[9];
            for (int row = 0; row < 8; row++)
            {
                lineStart = 0;
                for (int col = 0; col < 8; col++)
                {
                    if (nNumbers[row, col] == 0)
                    {
                        lineStart++;
                        continue;
                    }

                    lineStart = col;
                    while (col < 8 && nNumbers[row, col] == 1)
                    {

                        col++;
                    }
                    count[col - lineStart]++;
                }
            }

            for (int col = 0; col < 8; col++)
            {
                lineStart = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (nNumbers[row, col] == 0)
                    {
                        lineStart++;
                        continue;
                    }

                    lineStart = row;
                    while (row < 8 && nNumbers[row, col] == 1)
                    {
                        row++;
                    }
                    count[row - lineStart]++;
                }
            }

            count[1] /= 2;
            for (int i = 8; i > 0; i--)
            {
                if (count[i] > 0)
                {
                Console.WriteLine(i);
                Console.WriteLine("{0} ", count[i]);
                break;
                }

            }
            
        }
    }

