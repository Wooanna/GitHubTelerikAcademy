using System;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}




    class Combinations
    {
        static void Main()
        {
            Console.WriteLine("N =");
             N = int.Parse(Console.ReadLine());
            Console.WriteLine("Size of row = ");
            int size = int.Parse(Console.ReadLine()); //how many digits in row 
            int[] array = new int[size];
            CombinationsGenerator(size - 1, array, start);
        }

        static int N = 0;
        static int start = 1;
        static void CombinationsGenerator(int index, int[] arr, int start)
        {
           
            if (index  < 0)
            {   //if we are done with one row we simply print it
                Print(arr);
            }
            else
            for (int i = start; i <= N; i++)
            {
                arr[index] = i;
                CombinationsGenerator(index - 1, arr, i + 1);
            }
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
       

