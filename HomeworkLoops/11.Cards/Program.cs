using System;
//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
//The cards should be printed with their English names. Use nested for loops and switch-case.

 

    class Cards
    {
        static void Main()
        {
            string[] colorCards = new string[4] {"Heart", "Club", "Diamond", "Spade"};
            string[] cards = new string[13] {"Ace", "King", "Jack", "Queen", "Two", "Tree", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            char[] CHARACTER  = new char[4] {'\u2665', '\u2660', '\u2666','\u2663'  };

            for (int i = 0; i <= 3; i++)
            {
               
                for (int j = 0; j <= 12; j++)
                {
                   // Console.Write(cards[j]);
                    Console.WriteLine("{0, 6}{1, 8} {2}  ",cards[j], colorCards[i], CHARACTER[i]);

                }
                Console.WriteLine();

            }
        }
    }

