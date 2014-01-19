using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

namespace CheckThirdBitOfANumber
{
    class CheckBit
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number witch third byte to be checked:");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            int position = 3;
            int mask = 1 << position;

            int CompareNumAndMask = number & mask;
            int bit = CompareNumAndMask  >> position;

            bool result = (bit == 1);

            Console.WriteLine(result);




        }
    }
}
