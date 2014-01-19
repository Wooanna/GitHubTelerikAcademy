using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class pingpong

        {
             static int firstPlayerPadSize = 4;
             static int secondPlayerPadSize = 4;
             static int ballPositionX = 0;
             static int ballPositionY = 0;
             static bool ballDirectoinUp = true;
             static bool ballDirectionRight = false;
             static int firstPlayerPosition = 0;
             static int secondPlayerPosition = 0;
             static int firstPlayerScore = 0;
             static int secondPlayerScore = 0;
             static Random randomGenerator = new Random();

            static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition;  y < firstPlayerPosition + firstPlayerPadSize; y++)
            {
                PrintAtPosition(0, y, '|');
                PrintAtPosition(1, y, '|');
            }
        }


        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y < secondPlayerPosition + secondPlayerPadSize; y++)
            {
                PrintAtPosition(Console.WindowWidth - 1, y, '|');
                PrintAtPosition(Console.WindowWidth - 2, y, '|');
            }
        }



       



        static void SetInitialPositions()
    {
        firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
        secondPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
        ballPositionX = Console.WindowWidth / 2;
        ballPositionY = Console.WindowHeight / 2;
    }

        
         static void DrawBall()
        {
            PrintAtPosition(ballPositionX, ballPositionY, '@');
        }



         static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.WriteLine("{0} - {1}", firstPlayerScore, secondPlayerScore);
        }

         static void Level2()
         {
             if (firstPlayerScore > 2)
             {
                 firstPlayerPadSize = 5;
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 2);
                 Console.WriteLine("~~~LEVEL 2~~~");
             }
             if (secondPlayerScore > 2)
             {
                 secondPlayerPadSize = 5;
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 2);
                 Console.WriteLine("GAME OVERRRRR!!!");
                 Thread.Sleep(10000);
             }
         }


              static void Level3()
         {
             if (firstPlayerScore > 4)
             {
                 firstPlayerPadSize = 6;
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 2);
                 Console.WriteLine("~~~LEVEL 3~~~");
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 14, 10);
                 Console.WriteLine("BRAO MASHINAAA, TI PREBI PESHOOOO");
                 Thread.Sleep(10000);
             }
             if (secondPlayerScore > 2)
             {
                 secondPlayerPadSize= 5;
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 2);
                 Console.WriteLine("GAME OVERRRRR!!!");
                 Thread.Sleep(10000);
             }
         }

          static void moveFirstPlayerDown()
        {
            if (firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize)
            {
                firstPlayerPosition++;
            }           
      
        }

        static void moveFirstPlayerUp()
        {

            if (firstPlayerPosition > 0)
            {
                firstPlayerPosition--;
            }
        }




        static void moveSecondPlayerDown()
        {
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize)
            {
                secondPlayerPosition++;
            }            
        }

        static void moveSecondPlayerUp()
        {

            if (secondPlayerPosition > 0)
            {
                secondPlayerPosition--;
            }
        }

        static void SecondPlayerAIMove()
        {
            int randomNumber = randomGenerator.Next(0, 2);
            if (randomNumber == 0)
           
            {
                if (ballDirectoinUp == true)
                {
                    moveSecondPlayerUp();
                }
                else
                {
                    moveSecondPlayerDown();
                }
            }
        }
        static void SetBallAtTheMiddle()
         {
             ballPositionX = Console.WindowWidth / 2;
             ballPositionY = Console.WindowHeight / 2;
         }

         static void MoveBall()
         {
             if (ballPositionY == 0)
             { 
                 ballDirectoinUp = false;
             }
             if (ballPositionY == Console.WindowHeight - 1)
             {
                 ballDirectoinUp = true;
             }

             if (ballPositionX == Console.WindowWidth - 1)
             {

                 SetBallAtTheMiddle();
                 ballDirectionRight = false;
                 firstPlayerScore++;
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 1);
                 Console.WriteLine("!!!FIRST player WINS!!!");
                 Console.ReadKey();

             }

             if (ballPositionX == 0)
             {
                 SetBallAtTheMiddle();
                 ballDirectionRight = true;
                 secondPlayerScore++;
                 Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 1);
                 Console.WriteLine("!!!PESHO player WINS!!!");
                 Console.ReadKey();
             
             }
             if (ballPositionX < 3)
             {
                 if (ballPositionY >= firstPlayerPosition
                      && ballPositionY < firstPlayerPosition + firstPlayerPadSize)
                 {
                     ballDirectionRight = true;
                 }
             }

             if (ballPositionX >= Console.WindowWidth - 4)
             {
                 if (ballPositionY >= secondPlayerPosition
                     &&
                     ballPositionY < secondPlayerPosition + secondPlayerPadSize)
                 {
                     ballDirectionRight = false;
                 }
             }

             if (ballDirectionRight)
             {
                 ballPositionX++;
             }

             else 
             {
                 ballPositionX--;
             }


             if (ballDirectoinUp)
             {
                 ballPositionY--;
             }
             else
             {
                 ballPositionY++;
             }
         }

          

        static void RemoveScrollBars() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BufferHeight = Console.WindowHeight;
           Console.BufferWidth = Console.WindowWidth;
        }

       
        static void Main()
        {   
            RemoveScrollBars();
            SetInitialPositions();
              while (true)
               {
                   if (Console.KeyAvailable)
                   {


                       ConsoleKeyInfo keyInfo = Console.ReadKey();
                       if (keyInfo.Key == ConsoleKey.UpArrow)
                       {
                           moveFirstPlayerUp();
                       }
                       if (keyInfo.Key == ConsoleKey.DownArrow)
                       {
                           moveFirstPlayerDown();

                       }
                   }

                   MoveBall();
                    //move first player
                   SecondPlayerAIMove();
                    //redraw all
                  Console.Clear();
                    DrawFirstPlayer();
                    DrawSecondPlayer();
                    DrawBall();
                    PrintResult();
                    Level2();
                    Level3();
                    Thread.Sleep(100);

               }
             

        }

   

     
     

       

    }
}
    

