using System;

class AngryBits
{
    static void Main()
    {
        int[,] playfield = new int[8, 16];
        int mask = 1;
        for (int row = 0; row < 8; row++)
        {
            int input = int.Parse(Console.ReadLine());
            for (int col = 0; col < 16; col++)
            {
                if ((input & (mask << col )) != 0)
                {
                    playfield[row, col] = 1;
                }

            }
        }
        
        //prevrashtam prasetata v '2'
        for (int row = 0; row < 8; row++)
        {
            for (int col =0; col < 8; col++)
            {
                if (playfield[row, col] == 1)
                {
                    playfield[row, col] = 2;
                }
            }
        }

        //принтиране на полето.
        //for (int row = 0; row < 8; row++)
        //{
        //    for (int col = 0; col < 16; col++)
        //    {
        //        Console.Write(playfield[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        int currentCol = 0;
        int currentRow = 0;
        int moveCounter = 0;
        int pigsCounter = 0;
        int result = 0;
        int finalResult = 0;
        //движение на птиците           
        for (int col = 8; col < 16; col++) //tyrsim pile
        {
            currentCol = col;
            for (int row = 7; row >= 0; row--) //tyrsim pile
            {
                currentRow = row;
                result = 0;
                moveCounter = 0;
                pigsCounter = 0;

                if (playfield[row, col] == 1 && playfield[row - 1, col - 1] == 0)  //ako ima pile go mestim NAGORE
                {
                    while (true)
                    {
                        playfield[currentRow - 1, currentCol - 1] = 1;
                        playfield[currentRow, currentCol] = 0;
                        currentCol--;
                        currentRow--;
                        moveCounter++;

                        // Killing Angry PIGS part ONE


                        if (playfield[currentRow, currentCol] == 2)
                        {


                            for (int Row = currentRow - 1; Row <= currentRow + 1; Row++)
                            {
                                for (int Col = currentCol - 2; Col <= currentCol + 1; Col++)
                                {
                                    if (playfield[Row, Col] == 2)
                                    {
                                        pigsCounter++;
                                        playfield[Row, Col] = 0;
                                    }
                                }
                            }
                            break;

                        }
                        else if (currentRow <= 0)
                        {
                            break;
                        }

                    }

                    while (true) // pochvame da mestim nadolu
                    {
                        playfield[currentRow + 1, currentCol - 1] = 1;
                        playfield[currentRow, currentCol] = 0;
                        currentCol--;
                        currentRow++;
                        moveCounter++;
                        // killing Angry PIGS part TWO
                        if (playfield[currentRow , currentCol] == 2)
                        {
                            
                            for (int Row = currentRow - 1; Row <= currentRow + 1; Row++)
                            {
                                for (int Col = currentCol - 1; Col <= currentCol + 1; Col++)
                                {
                                    if (Row >= 0 && Col >= 0 && Row < 8)
                                    {
                                        if (playfield[Row, Col] == 2)
                                        {
                                            pigsCounter++;
                                            playfield[Row, Col] = 0;
                                        }
                                    }
                                }
                            }
                            result = moveCounter * pigsCounter;
                            break;
                        }
                       
                           

                    }
                   

                    result = moveCounter * pigsCounter;  finalResult += result;
                }

               




            }
           
        }
        Console.WriteLine("{0} Yes",finalResult);
        //Console.WriteLine(moveCounter);
        //Console.WriteLine(pigsCounter);
        //принтиране на полето.
        //Console.WriteLine();
        //for (int row = 0; row < 8; row++)
        //{
        //    for (int col = 0; col < 16; col++)
        //    {
        //        Console.Write(playfield[row, col]);
        //    }
        //    Console.WriteLine();
        //}
    }
}

