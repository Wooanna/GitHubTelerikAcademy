using System;

class FireMatrix
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int OuterDots = N / 2 - 1;
        int innerDots = 0;
        int outerDotsSecondPart = 0;
        int innerDotsSecondPart = N - 2;
        int numSlashes = N / 2;
        int outerDotsThirdPart = 0;


        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', OuterDots));
            Console.Write('#');
            Console.Write(new string('.', innerDots));
            Console.Write(new string('.', innerDots));
            Console.Write('#');
            Console.WriteLine(new string('.', OuterDots));
            OuterDots--;
            innerDots++;


        }

        for (int i = 0; i < N / 4; i++)
        {

            Console.Write(new string('.', outerDotsSecondPart));
            Console.Write('#');
            Console.Write(new string('.', innerDotsSecondPart));

            Console.Write("#");
            Console.WriteLine(new string('.', outerDotsSecondPart));

            outerDotsSecondPart++;
            innerDotsSecondPart -= 2;

        }

        Console.WriteLine(new string('-', N));

        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', outerDotsThirdPart));
            Console.Write(new string('\\', numSlashes));
            Console.Write(new string('/', numSlashes));
            Console.WriteLine(new string('.', outerDotsThirdPart));

            outerDotsThirdPart++;
            numSlashes--;




        }


    }
}