using System;
//Write a program that finds the greatest of given 5 variables.

class FindTheGreatest
{
    static void Main()
    { 
        string [] numbers = {"fisrst", "second", "third", "fourth", "fifth"} ;
        int N = 5;
        double max = double.MinValue;

        for (int i = 0; i < N; i++)
            
        {
            Console.WriteLine("Enter {0} number to be compared in each row:", numbers[i] );
            double temp = double.Parse(Console.ReadLine());
            

            if (temp > max)
            {
               max = temp;
            }

        }
        Console.WriteLine("The maximum number is: {0}", max);
        
    }
}

