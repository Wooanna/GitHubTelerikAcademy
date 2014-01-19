using System;




    class HexadecimalFormat
    {
        static void Main(string[] args)
        {
            int intNumber = 254;
            string hex = intNumber.ToString("X") ;
            Console.WriteLine(hex);
        }
    }

