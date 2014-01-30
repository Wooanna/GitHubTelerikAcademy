using System;
using System.Collections.Generic;
using System.Text;

    class SevenSegmentsDisplay
    {
         
        static void Main()
        {
            string[] digits = new string[] { "1111110", "0110000", "1101101", "1111001", "0110011", "1011011", "1011111", "1110000", "1111111", "1111011" };
            int CountOfDigits = int.Parse(Console.ReadLine());
            ulong[][] matrix = new ulong[CountOfDigits][];

            for (int i = 0; i < CountOfDigits; i++)
            {
                List<ulong> jaggedList = new List<ulong>();

                string numberStr = Console.ReadLine().Trim();
                for (ulong j = 0; j <= 9; j++)
                {
                    if (numberStr[0] <= digits[j][0] &&
                        numberStr[1] <= digits[j][1] &&
                        numberStr[2] <= digits[j][2] &&
                        numberStr[3] <= digits[j][3] &&
                        numberStr[4] <= digits[j][4] &&
                        numberStr[5] <= digits[j][5] &&
                        numberStr[6] <= digits[j][6] )
                    {
                        jaggedList.Add(j);
                    }
                }
                matrix[i] = jaggedList.ToArray();

            }

            List<ulong> list = new List<ulong>();
            
            for (int i = 0; i < matrix[0].Length; i++)
            {
                list.Add(matrix[0][i]);
            }
            for (int i = 1; i < CountOfDigits; i++)
            {
                list = GenCombinations(list, matrix[i]);
            }
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString().PadLeft(CountOfDigits, '0')); 
            }
            
    }
        private static List<ulong> GenCombinations(List<ulong> list, ulong[] matrix)
        {
            List<ulong> newList = new List<ulong>();

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    newList.Add(list[i] * 10 + matrix[j]);
                }
            }
            return newList;
        }
}


