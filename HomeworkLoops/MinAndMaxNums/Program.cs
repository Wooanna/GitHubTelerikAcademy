using System;
//Write a program that reads from the console a sequence of N integer numbers 
//and returns the minimal and maximal of them.

class MinAndMaxNums
{
    static void Main()
    {
        
   
        
        //Console.WriteLine("To:");
        //int N = int.Parse(Console.ReadLine());
        //int[] arr = new int[N];
            
        //for (int i = 0; i < N; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());         

           
            
        //}
        //Array.Sort(arr);
        //Console.WriteLine(arr[0]);
        //Console.WriteLine(arr[N-1]);

        int N = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 1; i < N; i++)
        {

            int temp = int.Parse(Console.ReadLine());

            if (temp > max)
            {
                max = temp;
            }
            if (temp < min)
            {
                min = temp;
            }

        }
        Console.WriteLine("Maximum number is: {0} \n Minimum number is {1}", max, min);


       





    }
}

