using System;
using System.Collections.Generic;
using System.Text;


class Lines
{
    public static int height, width, depth;
    private static int bestLineLength = 0;
    private static int bestNumberOfLines = 0;
    private static char[, ,] cube;
    

    static void Main()
    {
        string dimentions = Console.ReadLine();
        string[] dimentionsSplitted = dimentions.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        width = int.Parse(dimentionsSplitted[0]); //4
        height =  int.Parse(dimentionsSplitted[1]); // 3
        depth =  int.Parse(dimentionsSplitted[2]); // 5
         cube = new char[width, height, depth];
        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split();
            for (int d = 0; d < depth; d++)
            {
                string cubeContent = line[d];
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = cubeContent[w];
                }
            }
        }

        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    Find3DLines(w, h, d);
                    
                }
            }
        }

        Console.WriteLine("{0} {1}", bestLineLength, bestNumberOfLines);
    }

    private static int[] dirWidth = {1, 0, 1, -1, 0, 0, 0, 1, -1, 1, 1, 1, 1 };
    private static int[] dirHeigth = {0, 1, 0, 0, 0, 1, 1, 1, 1, 1, -1, 1, -1};
    private static int[] dirDepth = {0, 0, 1, 1, 1, 1, -1, 0, 0, 1, 1, -1, -1};

    private static void Find3DLines(int w, int h, int d)
    {
        char currentCell = cube[w, h, d];
        for (int i = 0; i < dirDepth.Length; i++)
        {
            int currentLineLength = 1;
            int currWidth = w;
            int currHeight = h;
            int currDepth = d;

            while (true)
            {
                currWidth += dirWidth[i];
                currHeight += dirHeigth[i];
                currDepth += dirDepth[i];

                if (!isInCube(currWidth, currHeight, currDepth))
                {
                    break;
                }
                if (cube[currWidth, currHeight, currDepth] == currentCell)
                {
                    currentLineLength++;
                }
                else
                {
                    break;
                }
            }

            if (currentLineLength > bestLineLength)
            {
                bestLineLength = currentLineLength;
                bestNumberOfLines = 1;
            }
            else if(currentLineLength == bestLineLength)
            {
                bestNumberOfLines++; 
            }

        }
    }

    private static bool isInCube(int w, int h, int d)
    {
        if (w >= 0 && h >= 0 && d >= 0 && w < width && h < height && d < depth)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

