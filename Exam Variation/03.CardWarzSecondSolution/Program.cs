using System;

class CardWarzSecondSolution
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int allGames = N;


        int firstPlayerAllOverScore = 0;
        int secondPlayerAllOverScore = 0;
        int firstPlayerIntermedScore = 0;
        int secondPlayerIntermedScore = 0;
        int gamesWonByPlayerFirst = 0;
        int gamesWonByPlayerSecond = 0;


        bool xCardDrawnByPlayerFirst = false;
        bool xCardDrawnByPlayerSecond = false;
        int countOfCards = 3;


        for (int i = 0; i < allGames; i++)
        {

            for (int j = 0; j < countOfCards; j++)
            {
                string input = Console.ReadLine();

		

                switch (input)
                {
                    case "Y": firstPlayerAllOverScore -= 200; break;
                    case "X": xCardDrawnByPlayerFirst = true; break;
                    case "Z": firstPlayerAllOverScore *= 2; break;
                    case "A": firstPlayerIntermedScore += 1; break;
                    case "J": firstPlayerIntermedScore += 11; break;
                    case "K": firstPlayerIntermedScore += 13; break;
                    case "Q": firstPlayerIntermedScore += 12; break;
                    case "2": firstPlayerIntermedScore += 10; break;
                    case "3": firstPlayerIntermedScore += 9; break;
                    case "4": firstPlayerIntermedScore += 8; break;
                    case "5": firstPlayerIntermedScore += 7; break;
                    case "6": firstPlayerIntermedScore += 6; break;
                    case "7": firstPlayerIntermedScore += 5; break;
                    case "8": firstPlayerIntermedScore += 4; break;
                    case "9": firstPlayerIntermedScore += 3; break;
                    case "10": firstPlayerIntermedScore += 2; break;
                }

                for (int k = 0; k < countOfCards; k++)
                {
                    switch (input)
                    {
                        case "Y": secondPlayerAllOverScore -= 200; break;
                        case "X": xCardDrawnByPlayerSecond = true; break;
                        case "Z": secondPlayerAllOverScore *= 2; break;
                        case "A": secondPlayerIntermedScore += 1; break;
                        case "J": secondPlayerIntermedScore += 11; break;
                        case "K": secondPlayerIntermedScore += 13; break;
                        case "Q": secondPlayerIntermedScore += 12; break;
                        case "2": secondPlayerIntermedScore += 10; break;
                        case "3": secondPlayerIntermedScore += 9; break;
                        case "4": secondPlayerIntermedScore += 8; break;
                        case "5": secondPlayerIntermedScore += 7; break;
                        case "6": secondPlayerIntermedScore += 6; break;
                        case "7": secondPlayerIntermedScore += 5; break;
                        case "8": secondPlayerIntermedScore += 4; break;
                        case "9": secondPlayerIntermedScore += 3; break;
                        case "10": secondPlayerIntermedScore += 2; break;

                    }
                }

                    if (xCardDrawnByPlayerSecond && xCardDrawnByPlayerFirst)
                    {
                        firstPlayerIntermedScore += 50;
                        secondPlayerIntermedScore += 50;
                    }

                    if (xCardDrawnByPlayerFirst)
                    {
                        Console.WriteLine("X card drawn! Player one wins the match!");
                    }
                    else if (xCardDrawnByPlayerSecond)
                    {
                        Console.WriteLine("X card drawn! Player two wins the match!");
                    }
                    if (firstPlayerIntermedScore < secondPlayerIntermedScore)
                    {
                        gamesWonByPlayerSecond++;
                    }
                    else if (secondPlayerIntermedScore < firstPlayerIntermedScore)
                    {
                        gamesWonByPlayerFirst++;
                    }
                    
                

                if (firstPlayerAllOverScore > secondPlayerAllOverScore)
                {
                    Console.WriteLine("First player wins! ");
                    Console.WriteLine("Score: {0}", firstPlayerAllOverScore);
                    Console.WriteLine("Games won: {0}", gamesWonByPlayerFirst);
                }
                else if (firstPlayerAllOverScore < secondPlayerAllOverScore)
                {
                    Console.WriteLine("Second player wins! ");
                    Console.WriteLine("Score: {0}", secondPlayerAllOverScore);
                    Console.WriteLine("Games won: {0}", gamesWonByPlayerFirst);
                }
                else if (firstPlayerAllOverScore == secondPlayerAllOverScore)
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", secondPlayerAllOverScore);
                    
                    

                }




            }



        }

    }
}


