using System;
//Write a program that prints all the numbers from 1 to N.




class OneToN
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number: ");
        int N = int.Parse(Console.ReadLine());
      
        for (int i = 0; i < N; i++)
        {
            
            Console.WriteLine(i);
        }

    }
}

