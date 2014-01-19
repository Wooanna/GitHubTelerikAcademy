using System;
using System.Text;
//Write a program to convert decimal numbers to their binary representation.

    class DecimalToBinary
    {
        static void Main()
        {
            int number;
            do
            {
                Console.WriteLine("Please enter number: ");
                
            } while (!int.TryParse(Console.ReadLine(), out number));

            ConvertToBinary(number);
        }

        private static void ConvertToBinary(int number)
        {
            StringBuilder stringBiuld = new StringBuilder();
            if (number == 0)
            {
                Console.WriteLine("Binary: 0");
            }
            while (number > 0)
            {
                int result = number % 2;
                number = number / 2;
                if (result == 1)
                {
                    stringBiuld.Append("1");
                }
                else if (result == 0)
                
                {
                    stringBiuld.Append("0");
                }
            }


            Print(stringBiuld);
        }

        private static void Print(StringBuilder stringBiuld)
        {
            for (int i = stringBiuld.Length - 1; i >= 0; i--)
            {
                Console.Write(stringBiuld[i]);
            }
            Console.WriteLine();
        }
    }

