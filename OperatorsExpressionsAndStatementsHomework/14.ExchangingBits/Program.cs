using System;

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a number which bits to be exchanged:");
            int number = int.Parse(Console.ReadLine());
            int numberCopyOne;
            int numberCopyTwo;
            int extractFirstBit;
            int extractSecondBit;

            Console.Write("Enter  first bit from the first seqience to start exchanging from:");
            int firstBit = int.Parse(Console.ReadLine());

            Console.Write("Enter a first bit for the second sequence of bits to be exchanged: ");
            int secondBit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter lenght of sequence of bits to be exchanged:");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            for (int i = 0; i < k; i++)
            {
                numberCopyOne = number;
                numberCopyTwo = number;

                extractFirstBit = numberCopyOne >> (firstBit + i) & 1;
                extractSecondBit = numberCopyTwo >> (secondBit + i) & 1;

                //set on position (secondBit + i)
                if (extractFirstBit == 1)
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
                if (extractSecondBit == 1)
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

