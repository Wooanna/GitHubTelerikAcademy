using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.


namespace ExchangingBits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopyOne;
            int numberCopyTwo;
            int setFirstBit;
            int setSecondBit;

            int firstBit = 3;
            int secondBit = 24;
            int k = 3;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            for (int i = 0; i < k; i++)
            {
                numberCopyOne = number;
                numberCopyTwo = number;

                setFirstBit = numberCopyOne >> (firstBit + i) & 1;
                setSecondBit = numberCopyTwo >> (secondBit + i) & 1;

                //set on position (secondBit + i)
                if (setFirstBit == 1)
                {

                    int mask = 1 << (secondBit + i);
                    number = number | mask;
                }
                else
                {
                    int mask = ~(1 << (secondBit + i));
                    number = number & mask;
                }

                //set on position (firstBit + i)
                if (setSecondBit == 1)
                {
                    int mask = 1 << (firstBit + i);
                    number = number | mask;
                }
                else
                {
                    int mask = ~(1 << (firstBit + i));
                    number = number & mask;
                }

            }

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        }
    }
}
