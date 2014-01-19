using System;

    class SandGlass
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int dotsCount = 0;
            int starsCount = N;
            for (int row = 0; row <= N / 2 - 1; row++)
            {
                Console.Write(new string('.', dotsCount));
                Console.Write(new string('*',starsCount));
                Console.Write(new string('.', dotsCount));
                Console.WriteLine();

                starsCount -= 2; ;
                dotsCount++;


            }
            Console.Write(new string('.', dotsCount));
                Console.Write(new string('*', starsCount));
                Console.Write(new string('.', dotsCount));
                Console.WriteLine();

            starsCount += 2;
            dotsCount--;
            for (int i = N/2 + 1; i <  N; i++)
            {
                Console.Write(new string('.', dotsCount));
                Console.Write(new string('*',starsCount));
                Console.Write(new string('.', dotsCount));
                Console.WriteLine();
                starsCount += 2;
                dotsCount--;

            }

           
        }
    }

