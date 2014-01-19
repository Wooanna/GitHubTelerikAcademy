using System;
using System.Numerics;
//Card	    2	3	4	5	6	7	8	9	10	A	J	Q	K
//Points   	10	9	8	7	6	5	4	3	2	1	11	12	13


class CardWarz
{
    static void Main()
    {
        
        BigInteger firstPlayerHandStrenghtAllGames = 0;
        BigInteger secondPlayerHandStrenghtAllGames = 0;
        
        
        string[] card = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
        int[] points = new int[13] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };
        string specialCardX = "X";
        string specialCardZ = "Z";
        string specialCardY = "Y";
        int gamesWonByPlayerFirst = 0;
        int gamesWonByPlayerSecond = 0;
        bool isXCardDrawnByPlayerFirst = false;
        bool isXCardDrawnByPlayerSecond = false;
        int localGamesCount = int.Parse(Console.ReadLine());
        for (int a = 0; a < localGamesCount; a++)
        {
            BigInteger firstPlayerHandStrenght = 0;
            BigInteger secondPlayerHandStrenght = 0;

                                    for (int i = 0; i < 3; i++)
                                    {
                                        string playerFirstCardDrawn = Console.ReadLine();

                                        for (int j = 0; j <= 12; j++)
                                        {
                                            if (playerFirstCardDrawn == card[j])
                                            {
                                                firstPlayerHandStrenght += points[j];
                                            }

                                            if (playerFirstCardDrawn == specialCardX)
                                            {
                                                isXCardDrawnByPlayerFirst = true;
                                            }
                                            if (playerFirstCardDrawn == specialCardY)
                                            {
                                                firstPlayerHandStrenght -= 200;
                                            }
                                            if (playerFirstCardDrawn == specialCardZ)
                                            {
                                                firstPlayerHandStrenght *= 2;
                                            }

                                        }
                                    }


                                    for (int i = 0; i < 3; i++)
			                        {
			                                string playerSecondCardDrawn = Console.ReadLine();
			
                                        for (int k = 0; k <= 12; k++)
                                        {
                    
                                            if (playerSecondCardDrawn == card[k])
                                            {
                                                secondPlayerHandStrenght += points[k];

                                            }
                                            if (playerSecondCardDrawn == specialCardX)
                                            {
                                                isXCardDrawnByPlayerSecond = true;
                                            }
                                            if (playerSecondCardDrawn == specialCardY)
                                            {
                                                secondPlayerHandStrenght -= 200;
                                            }
                                            if (playerSecondCardDrawn == specialCardZ)
                                            {
                                                secondPlayerHandStrenght *= 2;
                                            }

                                        }
                                    }

                                    if (secondPlayerHandStrenght < firstPlayerHandStrenght)
                                    {
                                        gamesWonByPlayerFirst++;
                                    }
                                    else if (firstPlayerHandStrenght < secondPlayerHandStrenght)
                                    {
                                        gamesWonByPlayerSecond++;
                                    }
                                    if (isXCardDrawnByPlayerFirst == true && isXCardDrawnByPlayerSecond == true)
                                    {
                                        firstPlayerHandStrenght += 50;
                                        secondPlayerHandStrenght += 50;
                                        isXCardDrawnByPlayerFirst = false;
                                        isXCardDrawnByPlayerSecond = false;
                                    }
                                    else if (isXCardDrawnByPlayerFirst == true)
                                    {
                                        Console.WriteLine("X card drawn! Player one wins the match!");
                                        return;
                                    }
                                    else if (isXCardDrawnByPlayerSecond == true)
                                    {
                                        Console.WriteLine("X card drawn! Player two wins the match!");
                                        return;
                                    }

                                    firstPlayerHandStrenghtAllGames = firstPlayerHandStrenght;
                                    secondPlayerHandStrenghtAllGames = secondPlayerHandStrenght;
                                    

        }

        if (gamesWonByPlayerFirst > gamesWonByPlayerSecond)
        {
            Console.WriteLine("First player wins!\nScore: {0}\nGames won: {1}",firstPlayerHandStrenghtAllGames, gamesWonByPlayerFirst);
        }
        else if (gamesWonByPlayerSecond > gamesWonByPlayerFirst)
        {
            Console.WriteLine("Second player wins!\nScore: {0}\nGames won: {1}", secondPlayerHandStrenghtAllGames, gamesWonByPlayerSecond);
        }
        else if (gamesWonByPlayerFirst == gamesWonByPlayerSecond)
        {
            
            Console.WriteLine("It's a tie!\nScore: {0}", secondPlayerHandStrenghtAllGames);
        }



    }
}

