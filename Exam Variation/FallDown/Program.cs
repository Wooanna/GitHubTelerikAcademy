using System;

class FallDown
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        int mask = 1;

        for (int row = 0; row < 8; row++)
        {
            int input = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((input & (mask << col)) != 0)
                {
                    matrix[row, col] = 1;
                }

            }
        }

        ////Print the matrix on the console
        //for (int row = 0; row < 8; row++)
        //{
        //    for (int col = 0; col < 8; col++)
        //    {
        //        Console.Write("{0}", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        //move boxes down

        for (int row = 7; row >= 0; row--)
        {
            for (int col = 0; col <= 7; col++)
            {
                for (int i = row; i < 7; i++)
                {
                    if (matrix[i, col] == 1 && matrix[i + 1, col] == 0)
                    {
                        matrix[i + 1, col] = 1;
                        matrix[i, col] = 0;
                    }
                }
            }
        }


        //Console.WriteLine();
        ////Print the matrix on the console changed
        //for (int row = 0; row < 8; row++)
        //{
        //    for (int col = 0; col < 8; col++)
        //    {
        //        Console.Write("{0}", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        for (int row = 0; row < 8; row++)
        {
            int output = 0;

            for (int col = 0; col < 8; col++)
            {


                if (matrix[row, col] == 1) 
                {
                    if (col == 0) { output += 1; }

                    else if (col == 1) { output += 2; }

                    else if (col == 2) { output += 4; }
                    else if (col == 3) { output += 8; }
                    else if (col == 4) { output += 16; }
                    else if (col == 5) { output += 32; }
                    else if (col == 6) { output += 64; }
                    else if (col == 7) { output += 128; }
                }


            }

            Console.WriteLine(output);
        }

    }


}


