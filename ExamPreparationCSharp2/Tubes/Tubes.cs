using System;

class Tubes
    {
        static void Main()
        {
            long tubes = long.Parse(Console.ReadLine());
            long fighters = long.Parse(Console.ReadLine());

            long[] theTubes = new long[tubes];
            //read input
            long sumOfTubes = 0;
            for (long i = 0; i < tubes; i++)
            {
                theTubes[i] = long.Parse(Console.ReadLine());
                sumOfTubes += theTubes[i];
            }
            Array.Sort(theTubes);

            //solution
            long left = 1;
            long right = theTubes[theTubes.Length - 1];
            long middle = 0;
            long key = fighters;
            long keyFoundSoFar = 0;
            long finalResult = 0;

            while (right >= left)
            {
                middle = (left + right) / 2;
                keyFoundSoFar = 0;
                for (long i = 0; i < theTubes.Length; i++)
                {
                    keyFoundSoFar += theTubes[i] / middle;
                }

                if (keyFoundSoFar < key)
                {
                    right = middle - 1;
                }
                if (keyFoundSoFar >= key)
                {
                    left = middle + 1;
                     finalResult = middle;
                }
            }
            Console.WriteLine(finalResult);
        }
    }

