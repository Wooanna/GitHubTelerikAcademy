using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoroTheRabbit
{
    static int[] numbers;

    static void Main()
    {
        ReadInput();
        GetResult(numbers);
    }

    private static void GetResult(int[] numbers)
    {
        int bestPath = 0;
        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                int index = startIndex;
                int currentPath = 1;
                int next = (index + step) % numbers.Length ;

                while ( numbers[index] < numbers[next]) //next != startIndex &&
                {
                    currentPath++;
                    index = next;
                    next = (index + step) % numbers.Length;
                }
                if (currentPath > bestPath)
                {
                    bestPath = currentPath;
                }
            }
        }
        Console.WriteLine(bestPath);
    }

    private static void ReadInput()
    {
        string path = Console.ReadLine();
        string[] pathNumbers = path.Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries);
         numbers = new int[pathNumbers.Length];
        for (int i = 0; i < pathNumbers.Length; i++)
        {
            numbers[i] = int.Parse(pathNumbers[i]);
        }
    }
}

