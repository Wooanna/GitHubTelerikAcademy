using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrossWord
{
    static bool hasResult;
    static int set;
    static int N;
    static void Main(string[] args)
    {
        set = int.Parse(Console.ReadLine());
        N = set * 2;
        string[] array = new string[set];
        string[] words = new string[N];
        for (int i = 0; i < N; i++)
        {
            words[i] = Console.ReadLine();
        }
         Array.Sort(words);

         GenerateVariations(set - 1,  array, words);
    }
    static void GenerateVariations(int index, string[] arr, string[] words)
    {
        if (index < 0)
        {
            if (!hasResult && Crossword(arr, words))
            {
                Print(arr);
                hasResult = true;
                
            }
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                arr[index] = words[i];
                GenerateVariations(index - 1, arr, words);
            }
        }
    }

    private static void Print(string[] arr)
    {
        foreach (var word in arr)
        {
            Console.WriteLine(word);
        }
    }

    static bool Crossword(string[] arr, string[] words)
    {
        StringBuilder word = new StringBuilder(words[0].Length);
        for (int col = 0; col < words[0].Length; col++)
        {
            word.Clear();
            for (int row = 0; row < words[0].Length; row++)
            {
                word.Append(arr[row][col]);
            }
            bool hasWord = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (word.ToString() == words[i])
                {
                    hasWord = true;
                    break;
                }
                
            }
            if (!hasWord)
            {
                return false;
            }
        }



        return true;
    }


}

