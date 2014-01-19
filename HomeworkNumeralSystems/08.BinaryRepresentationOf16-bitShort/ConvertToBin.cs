namespace BinaryRepresentationOf16bitShort
{
    using System;
    using System.Text;
    //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

    class ConvertToBinary
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());

            string result = ConvertToBin(number);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
        }

        private static string ConvertToBin(short number)
        {
            StringBuilder stringBuild = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                stringBuild.Append(number % 2);
                number /= 2;
            }

            return stringBuild.ToString();
        }
    }
}
