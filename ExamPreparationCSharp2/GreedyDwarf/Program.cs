using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] sValley = input.Split(new string[] { ", ", " ","," }, StringSplitOptions.RemoveEmptyEntries);
            int[] valley = new int[sValley.Length];
            for (int i = 0; i < sValley.Length; i++)
            {
                valley[i] = int.Parse(sValley[i]);
            }
            int numOfPatterns = int.Parse(Console.ReadLine());
            long mostAmountOfCoins = int.MinValue;
            long currentAmm = 0;

            for (int i = 0; i < numOfPatterns; i++)
            {
                string currentPattern = Console.ReadLine();
                string[] numbersInPattern = currentPattern.Split(new string[] { ", ", " ", "," }, StringSplitOptions.RemoveEmptyEntries);//??

                currentAmm = CalculateMostPattern(numbersInPattern, valley);

                if (mostAmountOfCoins < currentAmm)
                {
                    mostAmountOfCoins = currentAmm;
                    currentAmm = 0;
                }

            }
            Console.WriteLine(mostAmountOfCoins);

        }

        private static int CalculateMostPattern(string[] currentPattern, int[] valley)
        {
            int currAmountOfCoins = 0;
            //currAmountOfCoins += valley[0];

            bool[] isTaken = new bool[valley.Length];
            int stepIntex = 0;
            int patternIndex = 0;
            while (stepIntex >= 0 && stepIntex < valley.Length && !isTaken[stepIntex])
            {
                currAmountOfCoins = currAmountOfCoins + valley[stepIntex];

                isTaken[stepIntex] = true;
                stepIntex += int.Parse(currentPattern[patternIndex]);
                patternIndex = (patternIndex + 1) % currentPattern.Length;
            }

            return currAmountOfCoins;
        }
    }
}
