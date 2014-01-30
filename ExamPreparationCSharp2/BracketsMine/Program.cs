using System;
using System.Numerics;
using System.Text;


    class BracketsMine
    {
        static void Main()
        {
            string input = Console.ReadLine();

            BigInteger[][] table = new BigInteger[input.Length + 2][];
            table[1] = new BigInteger[input.Length + 1];
            table[1][1] = 1;
           
            for (int row = 2; row < table.GetLength(0); row++)
            {
                table[row] = new BigInteger[input.Length + 1];
                for (int col = 1; col < table[row].Length; col++)
                {
                    if (row < table.Length  && col < table[row].Length  - 1)
                    {
                        if (input[row - 2] == '?')
                        {
                            table[row][col] = table[row - 1][col - 1] + table[row - 1][col + 1];
                            
                        }
                        if (input[row - 2] == '(')
                        {
                            table[row][col] = table[row - 1] [col - 1];
                        }
                        if (input[row - 2] == ')')
                        {
                            table[row][ col] = table[row - 1][col + 1];
                        }
                        
                    }
                }
                table[row - 1] = null;
            }
            //Print(table);
            Console.WriteLine(table[table.Length - 1][ 1]);
        }

        //private static void Print(BigInteger[,] table)
        //{
        //    for (int i = 0; i < table.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < table.GetLength(1); j++)
        //        {
        //            Console.Write("{0, 4}", table[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }

