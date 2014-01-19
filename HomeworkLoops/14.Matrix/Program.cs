using System;
// Write a program that reads a positive integer number N (N < 20)
//from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.



    class Matrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int currentRow = 0;
            int currentCol = 0;
            string direction = "right";

            //fill up matrix

            for (int i = 1; i <= (N * N)  ; i++)
            {
                if (direction == "right" && (currentCol >= N || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow++;
                    direction = "down";
                }
                else if (direction == "down" &&  (currentRow >= N ||matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol--;
                    direction = "left";
                }
                else if (direction == "left" && ( currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    currentRow--;
                    direction = "up";

                }
                else if (direction == "up" && ( currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    currentCol++;
                    direction = "right";
                }


                matrix[currentRow, currentCol] = i;
                if (direction == "right" )
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
                


            }

            //print the matrix

            for (int k = 0; k < N; k++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0, 4}", matrix[k, j]); 

                }
                Console.WriteLine();
                Console.WriteLine(); //leave an empty row 
            }
           


           
        }
    }

