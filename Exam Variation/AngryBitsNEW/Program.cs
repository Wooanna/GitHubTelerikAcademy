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
                if ((input & (mask << col)) != 0)
                {
                    playfield[row, col] = 1;
                }

            }
        }

        //prevrashtam prasetata v '2'
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (playfield[row, col] == 1)
                {
                    playfield[row, col] = 2;
                }
            }
        }

        //принтиране на полето.
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 16; col++)
            {
                Console.Write(playfield[row, col]);
            }
            Console.WriteLine();
        }
        int currentCol = 0;
        int currentRow = 0;
        int moveCounter = 0;
        int pigsCounter = 0;
        int result = 0;
        int finalResult = 0;
        int startBirdRow;
        int startBirdCol;
        for (int col = 8; col < 16; col++) //tyrsim pile
        {
            
            for (int row = 7; row >= 0; row--) //tyrsim pile
            {


                if (playfield[row, col] == 1)  //ako ima pile go mestim NAGORE
                {
                    playfield[row, col] = 0;
                    startBirdRow = row;
                    startBirdCol = col;
                    break;
                }
            }
            //directions
            string direction = "up";

            while (true)
            {
                if (currentRow == 0)
                {
                    direction = "down";
                }

                if (direction == "up")
                {
                    currentRow--;
                    currentCol--;
                }
                else if (direction == "down")
                {
                    currentRow++;
                    currentCol--;
                }

                if ((currentRow > 7) || (currentCol < 0))
                {
                    break;
                }

                //движение на птиците           

                if (playfield[currentRow, currentCol] == 2)
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
                    result = result + pigsCounter * (startBirdCol - currentCol);
                    break;
                }
            

            }




        }
        string yesOrNo = " Yes";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (playfield[i, j] == 1)
                {
                    yesOrNo = " No";
                    break;
                }
            }
            if (yesOrNo == " No")
            {
                break;
            }
        }
        // Console.WriteLine("{0} Yes", finalResult);
        // Console.WriteLine(moveCounter);
        // Console.WriteLine(pigsCounter);
        //// принтиране на полето.
        // Console.WriteLine();
        // for (int row = 0; row < 8; row++)
        // {
        //     for (int col = 0; col < 16; col++)
        //     {
        //         Console.Write(playfield[row, col]);
        //     }
        //     Console.WriteLine();
        // }


    }
}

