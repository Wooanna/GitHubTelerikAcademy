using System;

   class BitBall
    {
        static void Main()
       {

           int[,] playFieldOne = new int[8, 8];
           int[,] playFieldTwo = new int[8, 8];
           int mask = 1;
           int rowCounter = 0;
           // put the players on positions
           for (int row = 0; row < 8; row++)
           {
               int input = int.Parse(Console.ReadLine());
               for (int col = 0; col < 8; col++)
               {
                   if ((input & (mask << col)) != 0)
                   {
                       playFieldOne[row, col] = 1;
                   }
               }

           }

           for (int row = 0; row < 8; row++)
           {
               int input = int.Parse(Console.ReadLine());
               for (int col = 0; col < 8; col++)
               {
                   if ((input & (mask << col)) != 0)
                   {
                       playFieldTwo[row, col] = 1;
                   }
               }

           }

           ////print the two tables on the console
           //for (int row = 0; row < 8; row++)
           //{
           //    for (int col = 0; col < 8; col++)
           //    {
           //        Console.Write(playFieldOne[row, col]);

           //    }
           //    Console.WriteLine();
           //}
           //Console.WriteLine();


           //for (int row = 0; row < 8; row++)
           //{
           //    for (int col = 0; col < 8; col++)
           //    {
           //        Console.Write(playFieldTwo[row, col]);

           //    }
           //    Console.WriteLine();
           //}

           //check for two players on one position

           for (int row = 0; row < 8; row++)
           {
               for (int col = 0; col < 8; col++)
               {
                   if (playFieldOne[row, col] == 1 && playFieldTwo[row, col] == 1)
                   {
                       playFieldOne[row, col] = 0;
                       playFieldTwo[row, col] = 0;
                   }
               }
           }

           for (int row = 0; row < 8; row++)
           {
               for (int col = 0; col < 8; col++)
               {
                   if (playFieldOne[row, col] == 0 && playFieldTwo[row, col] == 1)
                   {
                       playFieldOne[row, col] = 2;
                   }
               }
           }

           //Console.WriteLine();
           //Console.WriteLine();
           //for (int row = 0; row < 8; row++)
           //{
           //    for (int col = 0; col < 8; col++)
           //    {
           //        Console.Write(playFieldOne[row, col]);
           //    }
           //    Console.WriteLine();

           //}




           //move the B players '2' up
           for (int col = 0; col < 8; col++)
           {
               for (int row = 7; row >= 0; row--)
               {


                   for (int i = 7; i > row; i--)
                   {
                       if (playFieldOne[i, col] == 2 && playFieldOne[i - 1, col] == 0)
                       {
                           playFieldOne[i - 1, col] = 2;
                           playFieldOne[i, col] = 0;
                       }
                   }

               }
           }
           // move the T players '1' down
           for (int col = 0; col < 8; col++)
           {
               for (int row = 0; row < 7; row++)
               {


                   for (int i = row; i < 7; i++)
                   {
                       if (playFieldOne[i, col] == 1 && playFieldOne[i + 1, col] == 0)
                       {
                           playFieldOne[i + 1, col] = 1;
                           playFieldOne[i, col] = 0;
                       }
                   }
               }

           }

           int playerOneScore = 0;
           int playerTwoScore = 0;

           for (int i = 0; i < playFieldOne.GetLength(0); i++)
           {
               if (playFieldOne[0, i] == 2)
               {
                   playerOneScore++;
               }
               if (playFieldOne[7, i] == 1)
               {
                   playerTwoScore++;
               }
           }

           //print result
           Console.WriteLine("{1}:{0}", playerOneScore, playerTwoScore);
           
           //Console.WriteLine();
           //Console.WriteLine();
           //for (int row = 0; row < 8; row++)
           //{
           //    for (int col = 0; col < 8; col++)
           //    {
           //        Console.Write(playFieldOne[row, col]);
           //    }
           //    Console.WriteLine();
           //}










       }
    }

