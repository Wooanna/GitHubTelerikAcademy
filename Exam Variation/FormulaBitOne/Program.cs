using System;

//задачата работи на 70/100. Не успях да я докарам до край. Дава някъде ексепшън (извън рамките на масива)

class FormulaBitOne
{
    static void Main()
    {
        int[,] playField = new int[10, 10]; // разширявам матрицата с по едно от всяка страна, за да го запълня с единици

        int counterOfLenght = 0;
        string direction = "south/down";
        int currentRow = 1; // започвам от 1, защото на [0, 0] Имам единици, които не играят роля. Тях ги сложих, за да може като стигне брояча до '1' да сменя посоката, 
        int currentCol = 1; // без да се налага да правя проверки за излизане от масива.
        int turnsCounter = 0;
        int counterTurningFromLeftToD = 0; // товааа... го сложих за да мога да броя когато обхождам на ляво и трябва да сменя посоката дали да тръгне надолу или нагоре;
        //ако е четно ще е надолу, ако нечетно нагоре; Сигурно не е много вярно.

        int mask = 1;
        //popalvane na matricata
        for (int row = 1; row < 9; row++)
        {
            int input = int.Parse(Console.ReadLine());
            for (int col = 1; col < 9; col++)
            {
                if ((input & (mask << col - 1)) != 0)
                {
                    playField[row, col] = 1;
                }
            }
        }
        //запълвам левия ръб с единици;
        for (int col = 0; col < 1; col++)
        {
            for (int row = 0; row < 10; row++)
            {
                playField[row, col] = 1;
            }
        }
        //запълвам десния ръб с единици;
        for (int col = 9; col < 10; col++)
        {
            for (int row = 0; row < 10; row++)
            {
                playField[row, col] = 1;
            }
        }
        //запълвам горния ръб с единици;
        for (int row = 0; row < 1; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                playField[row, col] = 1;
            }
        }
        //запълвам долнияръб с единици;
        for (int row = 9; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                playField[row, col] = 1;
            }
        }



        // print the matrix on the console
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(playField[row, col]);
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 64; i++)
        {

          
            if (playField[currentRow, currentCol] == 0)
            {
                counterOfLenght++;
            }
            else
            {
               
            }
            



            if ((direction == "south/down" && playField[currentRow + 1, currentCol] == 1)) //вървим надолу, ако следващата клетка е '1' сменяме посоката
            {
               
                     direction = "west/left";
                
                turnsCounter++;

                

            }
            else if ((direction == "west/left" && playField[currentRow, currentCol + 1] == 1)) //(Тук даде грешка) пак така..
            {
                counterTurningFromLeftToD++;
                if (counterTurningFromLeftToD % 2 == 0)     // и при вход 2, 38, 20, 48, 111, 15, 3, 43 би трябвало да тръгне надолу
                {
                    direction = "south/down";
                    turnsCounter++;                           
                }
                else
                {
                    direction = "North/Up";
                    turnsCounter++;
                }

            }

            else if ((direction == "North/Up" && playField[currentRow - 1, currentCol] == 1))
            {
                direction = "west/left";
                turnsCounter++;
            }


            
                if (direction == "south/down")
            {
                currentRow++;
            }
            else if (direction == "west/left")
            {
                currentCol++;
            }
            else if (direction == "North/Up")
            {

                currentRow--;

            }
          
            
           
        }
        
        if (currentRow == 8 && currentCol == 8)
        {
            
            Console.WriteLine("{0} {1}", counterOfLenght, turnsCounter);
            
        }
        else
        {
            Console.WriteLine("No {0}", counterOfLenght);


        }
    }
}


