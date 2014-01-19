using System;
//Write a program that reads two arrays from the console and compares them element by element.

class ArrCompare
{
    static void Main()
    {
        Console.Write("Enter lenght of arrays: ");
        int n = int.Parse(Console.ReadLine()); // choose length of the array

        int[] firstArr = new int[n]; 
        int[] secondArr = new int[n];

        Console.WriteLine("Enter values for cells of the first array:"); //initialize first array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Cell {0}= ", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter values for cells of the second array:"); //initialize second array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Cell {0}= ", i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }


        bool equal = false;
        bool oneEqual = false;
        for (int i = 0; i < n; i++)
        {
            if (firstArr[i] == secondArr[i])
            {
                equal = true;

            }
            if (equal)
            {
                Console.Write("Equal: ");
                Console.Write("Position {0}, ", i);
                Console.Write("Value {0} ", firstArr[i]);
                Console.WriteLine();
                oneEqual = true;
            }
            equal = false;
        }
        if (!oneEqual)
        {
            Console.WriteLine("There are no equal elements.");
        }
    }
}

