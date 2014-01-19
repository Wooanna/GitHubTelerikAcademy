using System;

class MissCat2011
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] votes = new int[N];
        int[] counterVotes = new int[11];
        int Max = int.MinValue;

        for (int i = 0; i < N; i++)
        {
            int inputCatNum = int.Parse(Console.ReadLine());
            votes[i] = inputCatNum;
            for (int j = 1; j < counterVotes.Length; j++)
            {
                if (inputCatNum == j)
                {
                    counterVotes[j]++;
                }
            }
        }

        int result = 0;
        //Console.WriteLine(counterVotes[counterVotes.Length -1]);
        for (int i = 0; i < counterVotes.Length - 1; i++)
        {           

            if (counterVotes[i] >= Max)
            {
                Max = counterVotes[i];
               result = i;
            }
            

        }

        Console.WriteLine(result);
       



    }
}

