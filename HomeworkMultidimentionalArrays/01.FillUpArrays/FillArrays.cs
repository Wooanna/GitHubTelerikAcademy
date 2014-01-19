using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class FillArrays
{
    static int n;
    static int[,] myArray = new int[n, n];

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the dimentions of the array: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("First result:");
        FirstSolution(myArray);
        Console.WriteLine();
        Console.WriteLine("Second result:");
        SecondSolution(myArray);
        Console.WriteLine();
        Console.WriteLine("Third result:");
        ThirdSolution(myArray);
        Console.WriteLine();
        Console.WriteLine("Fourth result:");
        FourthSolution(myArray);

    }

    static void PrintMatrix(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write("{0, -3}", arr[row, col]);
            }

            Console.WriteLine();
        }
    }
    //solution a)
    static void FirstSolution(int[,] array)
    {
        array = new int[n, n];
        int number = 1;

        for (int row = 0; row < array.GetLength(1); row++)
        {
            for (int col = 0; col < array.GetLength(0); col++)
            {
                array[row, col] = number;
                number = (number + n);
            }
            number -= n * n;
            number++;

        }
        PrintMatrix(array);
    }
    //solution b)
    static void SecondSolution(int[,] array)
    {
        array = new int[n, n];
        int number = 1;
        for (int col = 0; col < array.GetLength(1); col += 2)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                array[row, col] = number;
                number++;
            }
            number += n;
        }
        if (n % 2 != 0)
        {
            number -= (n * n);
        }
        else number -= (n * n) - n;

        for (int col = 1; col < array.GetLength(1); col += 2)
        {
            for (int row = array.GetLength(1) - 1; row >= 0; row--)
            {
                array[row, col] = number;
                number++;
            }
            number += n;
        }
        PrintMatrix(array);
    }
    //solution c)
    static void ThirdSolution(int[,] array)
    {
        array = new int[n, n];
        int startRow = n - 1;
        int startCol = 0;
        int row = n - 1;
        int col = 0;
        int value = 1;
        array[row, col] = value; //1

        while (value < n * n)
        {
            if (row == n - 1 && col < n - 1)
            {
                startRow--;
                startCol = 0;
                row = startRow;
                col = startCol;       // Col = 0
                value++;
                array[row, col] = value;

                while (row < (n - 1) && col < (n - 1))
                {
                    row++;    //Move down
                    col++;    //Move right
                    value++;
                    array[row, col] = value;
                }
            }

            if (row <= (n - 1) && col == (n - 1))
            {
                startRow = 0;
                startCol++;
                row = startRow;   // Row = 0
                col = startCol;   // Col = 1,2,3,4...N-1
                value++;
                array[row, col] = value;

                while (col < (n - 1))
                {
                    row++;    //Move down
                    col++;    //Move right
                    value++;
                    array[row, col] = value;
                }
            }
        }
        PrintMatrix(array);
    }

    //solution d)
    static void FourthSolution(int[,] array)
    {
        array = new int[n, n];
        string direction = "down";
        int value = 1;
        int row = 0;
        int col = 0;
        while (value <= n * n)
        {
            array[row, col] = value++;
            if (direction == "down" && (row == n - 1 || array[row + 1, col] != 0)) { direction = "right"; }
            if (direction == "right" && (col == n - 1 || array[row, col + 1] != 0)) { direction = "up"; }
            if (direction == "up" && (row == 0 || array[row - 1, col] != 0)) { direction = "left"; }
            if (direction == "left" && (col == 0 || array[row, col - 1] != 0)) { direction = "down"; }

            if (direction == "down")
            {
                row++;
            }
            if (direction == "right")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
            if (direction == "left")
            {
                col--;
            }
        }

        PrintMatrix(array);
    }
}



