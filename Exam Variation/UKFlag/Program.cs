using System;

class UKFlag
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int innerdotsCount = (N - 3) / 2;
        int outerDotsCount = 0;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string ('.', outerDotsCount));
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', innerdotsCount));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', innerdotsCount));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', outerDotsCount));

            Console.WriteLine();
            outerDotsCount++;
                innerdotsCount--;

        }
        Console.Write(new string('-', (N - 1) /2));
        Console.Write(new string ('*', 1));
        Console.WriteLine(new string('-', (N - 1) / 2));
        outerDotsCount--;
        innerdotsCount++;

        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', outerDotsCount));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', innerdotsCount));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', innerdotsCount));
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', outerDotsCount));

            Console.WriteLine();
            outerDotsCount--;
            innerdotsCount++;

        }
    }
}

