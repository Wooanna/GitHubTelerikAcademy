using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SpecialValue
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] jaggedMatrix = new int[rows][];
        bool[][] isVisited = new bool[rows][];
        long maxValue = 0;

        for (int i = 0; i < jaggedMatrix.GetLength(0); i++)
        {
            string number = Console.ReadLine();
            string[] currentRow = number.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            jaggedMatrix[i] = new int[currentRow.Length];
            isVisited[i] = new bool[currentRow.Length];
            for (int j = 0; j < currentRow.Length; j++)
			{
                jaggedMatrix[i][j] = int.Parse(currentRow[j]);
			}
        }
        for (int i = 0; i < jaggedMatrix[0].Length; i++)
        {
               long specialValue = FindSpecialValue(jaggedMatrix, isVisited, i);
               if (maxValue < specialValue)
               {
                   maxValue = specialValue;
               }
            
        }
        Console.WriteLine(maxValue);
    }

    private static long FindSpecialValue(int[][] jaggedMatrix, bool[][] isVisited, int col)
    {
        
        long specialValue = 0;
        int row = 0;
       while(true)
       {
            if (isVisited[row][col])
            {
                return long.MinValue;
            }
            if (jaggedMatrix[row][col] < 0 )
            {
                specialValue++;
                specialValue += jaggedMatrix[row][col] * -1;
                return specialValue;

            }
            else
            {
                specialValue++;
                isVisited[row][col] = true;
                col = jaggedMatrix[row][col];

                row++;
                if (row == jaggedMatrix.GetLength(0))
                {
                    row = 0;
                }
            }
        }
        
       
    }

   

}

