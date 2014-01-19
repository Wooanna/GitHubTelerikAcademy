using System;


class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Z = (  X / 2) + 1;
        int width = (2 * X + 2 * Z) - 3;
        int height = width;

       int[,] canvas = new int[width, height];
       int currentRow = X / 2;
       int currentCol = 0;
        // fill canvas 

       while (true)
       {
           canvas[currentRow, currentCol] = 1;
           currentRow--;
           currentCol++;
           if (currentRow <= 0)
           {
               break;
           }
       }

       while (true)
       {
           canvas[currentRow, currentCol] = 1;
           currentRow++;
           currentCol++;
           if (currentCol > width - (X/2 + 2))
           {
               break;
           }
       }

       while (true)
       {
           canvas[currentRow, currentCol] = 1;
           currentCol--;
           currentRow++;
           if (currentRow >= height - 1 )
           {
               break;
           }
       }

       while (true)
       {
            canvas[currentRow, currentCol] = 1;
            currentCol--;
            currentRow--;
            if (currentCol < Z )
            {
                break;
            }
       }
       while (true)
       {
           canvas[currentRow, currentCol] = 1;
           currentCol++;
           currentRow--;
           if (currentRow <= 0)
           {
               break;
           }

       }
       while (true)
       {
           canvas[currentRow, currentCol] = 1;
           currentCol++;
           currentRow++;
           if (currentCol >= width )
           {
               break;
           }
       }
      
      

        //print canvas on console
       for (int row = 0; row < width; row++)
       {
           for (int col = 0; col < height; col++)
           {
               if (canvas[row, col] == 0)
               {
                   Console.Write('.');
               }
               else if (canvas[row, col] == 1)
               {
                   Console.Write('*');
               }
               
               
           }
           Console.WriteLine();
       }

    }
}

