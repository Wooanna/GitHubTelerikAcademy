using System;

class Bittris
{
    static void Main()
    {

        int[] playField = new int[4] { 0, 0, 0, 0 };


        const int moves = 3;
        int fallenDownNumber = 0;
        bool fullRow = false;
        long score = 0;
        long totalScore = 0;


        int N = int.Parse(Console.ReadLine());//kolko dvijenia obshto shte ima v igrata

        for (int i = 0; i < N / 4; i++)
        {
            int newNumber = int.Parse(Console.ReadLine());
            string numberStr = Convert.ToString(newNumber, 2);
            char bit = '0';
            for (int k = 0; k < numberStr.Length; k++)
            {
                if (numberStr[k] == '1')           //преброяване на точките от битчетата във всяко ново число (парченце от играта)
                {
                    score++;
                }
               
               
            }

            int mask = 255;
            newNumber =  mask & newNumber;
            bool landed = false;


            for (int j = 0; j < moves && landed == false; j++)
            {
                playField[0] = newNumber;

                char movement = char.Parse(Console.ReadLine());

                switch (movement)
                {
                    case 'L':
                        newNumber = newNumber << 1;
                        if (newNumber > 255)
                        {
                            newNumber = newNumber >> 1;
                        }
                       
                            
                       
                                                break;
                    case 'R': newNumber = newNumber >> 1;             break;
                    case 'D': newNumber = newNumber;                             break;
                    default:                                                        break;

                        


                       
                }
                
                if ( playField[j+1]  <= (255 - newNumber))
                        {
                            playField[j + 1] += newNumber;
                            playField[j] = 0;
                            playField[0] = 0;
                        }
                //fallenDownNumber += newNumber;
                //newNumber = 0;


            } 
            
                        if (playField[0] ==  255)
                        {
                            fullRow = true;                            
                            //score *= 10;
                            //totalScore += score;
                           
                        }
                        if (playField[1] == 255)
                        {
                            fullRow = true;
                            playField[1] = 0;
                            //score *= 10;
                            //totalScore += score;
                            playField[1] = playField[0];
                            
                        }
                        if (playField[2] == 255)
                        {
                            fullRow = true;
                            playField[2] = 0;
                            //score *= 10;
                            //totalScore += score;

                            playField[2] = playField[1];
                            playField[1] = playField[0];

                        }
                        if (playField[3] == 255)
                        {
                            fullRow = true;
                            playField[3] = 0;
                            //score *= 10;
                            //totalScore += score;
                            playField[3] = playField[2];
                            playField[2] = playField[1];
                            playField[1] = playField[0];
                        }
                        if (fullRow)
                        {
                            fullRow = false;
                            score *= 10;
                        }
                        totalScore += score;
                        score = 0;
                        
        }


        Console.WriteLine(totalScore);
        
    }
}

