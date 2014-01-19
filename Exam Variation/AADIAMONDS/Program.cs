using System;


namespace AADIAMONDS
{
    class Program
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());

            int innerdots = (N/2);
            int outerdots = (N / 2) ;

            Console.Write(new string('.', N / 2 + 1 ) );
            Console.Write(new string('*', N));
            Console.Write(new string('.', N / 2 + 1));
            Console.WriteLine();
            for (int i = 0; i < N/2; i++)
            { 
                Console.Write(new string ('.', outerdots));
                Console.Write(new string ('*', 1));
                Console.Write(new string ('.',innerdots));
                Console.Write(new string ('*', 1));
                Console.Write(new string('.', innerdots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', outerdots));
                Console.WriteLine();
               outerdots--;
                innerdots++;
            }
            outerdots++;
            innerdots--;

            Console.WriteLine(new string('*', N * 2 + 1));

            for (int i = 0; i < N - 1; i++)
            {
                Console.Write(new string('.', outerdots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', innerdots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.',innerdots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', outerdots));
                innerdots--;
                outerdots++;
                Console.WriteLine();
                

            }

            Console.Write(new string('.', N ));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', N));
            Console.WriteLine();



        }
    }
}
