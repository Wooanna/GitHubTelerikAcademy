using System;
using System.Collections.Generic;
using System.Text;


class Guitar
{
    static void Main()
    {
        string[] songsStrings = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] songs= new int[songsStrings.Length];
        for (int i = 0; i < songsStrings.Length; i++)
        {
            songs[i] = int.Parse(songsStrings[i]);
        }

        int start = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        bool[,] clever = new bool[songs.Length + 1, max + 1];

        clever[0, start] = true;

        for (int i = 1; i < clever.GetLength(0); i++)
        {
            var interval = songs[i - 1];
            for (int j = 0; j < clever.GetLength(1); j++)
            {
                if (clever[i -1, j] == true)
                {
                    if (j - interval >= 0)
                    {
                        clever[i, j - interval] = true;
                    }
                    if (j + interval <= max)
                    {
                        clever[i, j + interval] = true;
                    }
                }
            }
        }
        

        for (int i = max; i > 0; i--)
        {
            if (clever[songs.Length, i] == true)
            {
                Console.WriteLine(i);
                return;
            }
            
        }

        Console.WriteLine(-1);



    }
}

