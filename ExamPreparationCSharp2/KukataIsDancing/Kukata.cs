using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Kukata3D
{
    static void Main()
    {
        List<string> result = new List<string>();

        string currentDance = string.Empty;
        int dances = int.Parse(Console.ReadLine());
        for (int i = 0; i < dances; i++)
        {
            currentDance = Console.ReadLine();
           result.Add( KukataStartsDancing(FillUpKukataCube(), currentDance));

        }
        PrintResult(result); 
        
    }

    private static string[,] FillUpKukataCube()
    {
        string[,] kukataCube = new string[3, 3];
        kukataCube[0, 0] = "RED";
        kukataCube[0, 1] = "BLUE";
        kukataCube[0, 2] = "RED";
        kukataCube[1, 0] = "BLUE";
        kukataCube[1, 1] = "GREEN";
        kukataCube[1, 2] = "BLUE";
        kukataCube[2, 0] = "RED";
        kukataCube[2, 1] = "BLUE";
        kukataCube[2, 2] = "RED";

        return kukataCube;
    }

    private static string KukataStartsDancing(string[,] kukataCube, string currentDance)
    {
        //startingPos
        int row = 1;
        int col = 1;
        string theLastStepOfKukata = kukataCube[row, col];
        bool left = false;
        bool right = false;
        bool up = true;
        bool down = false;
       

            for (int i = 0; i < currentDance.Length; i++)
            {
                if (currentDance[i] == 'L')
                {
                    if (up)
                    {
                        left = true;
                        up = false;
                        down = false;
                        right = false;

                    }
                    else if (down)
                    {
                        left = false;
                        up = false;
                        right = true;
                        down = false;


                    }
                    else if (left)
                    {
                        down = true;
                        left = false;
                        right = false;
                        up = false;
                    }
                    else if (right)
                    {
                        up = true;
                        left = false;
                        right = false;
                        down = false;
                    }


                }
                else if (currentDance[i] == 'R')
                {

                    if (up)
                    {
                        left = false;
                        up = false;
                        down = false;
                        right = true;

                    }
                    else if (down)
                    {
                        left = true;
                        up = false;
                        right = false;
                        down = false;


                    }
                    else if (left)
                    {
                        down = false;
                        left = false;
                        right = false;
                        up = true;
                    }
                    else if (right)
                    {
                        up = false;
                        left = false;
                        right = false;
                        down = true;
                    }
                }
                else if (currentDance[i] == 'W')
                {
                    if (left)
                    {
                        col--;

                        if (col < 0)
                        {
                            col = 2;
                        }
                    }
                    if (right)
                    {
                        col++;

                        if (col >= 3)
                        {
                            col = 0;
                        }
                    }
                    if (up)
                    {
                        row--;

                        if (row < 0)
                        {
                            row = 2;
                        }
                    }
                    if (down)
                    {
                        row++;
                        if (row > 2)
                        {
                            row = 0;
                        }

                    }
                }

            }

            theLastStepOfKukata = kukataCube[row, col];
            return theLastStepOfKukata;
    }

    private static void PrintResult(List<string> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

