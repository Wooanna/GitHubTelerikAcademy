using System;


    class FirTree
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int dotsCount = N - 2;
            int starsCount = 1;

            for (int i = 0; i <N-1; i++)
            {
                Console.Write(new string('.', dotsCount));
            Console.Write(new string('*', starsCount));
            Console.Write(new string('.', dotsCount));
            Console.WriteLine();
            dotsCount--;
            starsCount += 2;
            }

            dotsCount = N - 2;
            starsCount = 1;

            Console.Write(new string('.', dotsCount));
            Console.Write(new string('*', starsCount));
            Console.Write(new string('.', dotsCount));
            Console.WriteLine();
        }
    }

