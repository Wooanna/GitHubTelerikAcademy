using System;
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter the number of the elements in your array? ");
        int n = int.Parse(Console.ReadLine());
        decimal[] myArray = new decimal[n];
        Random myRand = new Random();     

        decimal min = 0;  //here we store the curr min value
       
        for (int i = 0; i < n; i++) //fill up the arr
        {
            myArray[i] = myRand.Next(-10, 11);
        }

        Console.WriteLine(string.Join(", ", myArray));

        //solution
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i + 1; j < myArray.Length; j++)  //compare [j] with [j-1] if [j] > [j-1] put [j] in min, than put [j-1] in [j], than put min in [j-1];
            {
                if (myArray[j] < myArray[i])
                {
                    min = myArray[j];
                    myArray[j] = myArray[i];
                    myArray[i] = min;
                }
            }
        }

        //print result
        Console.WriteLine(String.Join(", ", myArray));
    }
}

