using System;

    class BatBoikoTower
    {
        static void Main()
        {
            int towerHeight = int.Parse(Console.ReadLine());
            int outerdDots = towerHeight - 1;
            int innerSigns = 0;           
            

            int towerWidth = towerHeight * 2;

            for (int row = 1; row <= towerHeight; row++)
            {
                
                Console.Write(new string('.', outerdDots ));
                Console.Write('/');
                if (row  == 2 || row == 4 || row == 7|| row == 11 || row == 16 || row == 22 || row == 29 || row == 37 )
                {
                    Console.Write(new string ('-', innerSigns));
                }
                else {
                    Console.Write(new string ('.', innerSigns));
                }
                Console.Write('\\');
                Console.WriteLine(new string('.', outerdDots));
                outerdDots--;
                innerSigns += 2;

            }




        }
    }

