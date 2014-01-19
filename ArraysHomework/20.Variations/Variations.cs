using System;
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


    class Variations
    {
        static int set;
        static int N;
        static void Main(string[] args)
        {
            Console.WriteLine("How log every set will be? ");
            set = int.Parse(Console.ReadLine());
            Console.WriteLine("How many elements included in it? ");
            N = int.Parse(Console.ReadLine());
            int[] array = new int[set];
            GenerateVariations(set - 1,  array);
        }

        static void GenerateVariations(int index, int[] arr)
        {
            if (index < 0)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    arr[index] = i;
                    GenerateVariations(index - 1, arr);
                }
            }
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }

