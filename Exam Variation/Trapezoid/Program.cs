using System;


namespace Trapezoid
{
    class Program
    {
        static void Main()
        {
            
            int N = int.Parse(Console.ReadLine());
            int downerSide = N * 2;
            int outerDots = N - 1;
            int innerDots = N - 1;

                Console.Write(new string('.', N) );
                Console.WriteLine(new string('*', N));//tova e parvi red 

            for (int i = 0; i < N-1; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.WriteLine('*');
                outerDots--;
                innerDots++;
                
            }

            Console.WriteLine(new string('*', downerSide));

        }
    }
}
