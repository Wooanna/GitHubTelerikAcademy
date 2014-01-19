using System;
//Write a program that prints all the numbers from 1 to N, 
//that are not divisible by 3 and 7 at the same time.

class NotDevBy3And7
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}

