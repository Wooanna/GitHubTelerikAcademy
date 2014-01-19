using System;



class ExtractingBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter a number of a bit whitch value to be extracted [0 to 32]");
        int bitNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number from whitch to extract");
        int numExtractingFrom = int.Parse(Console.ReadLine());

        int mask = 1 << bitNumber;
        int maskAndNum = numExtractingFrom & mask;
        int value = maskAndNum >> bitNumber;

        Console.WriteLine("The value bit of position {0} in number {2} is {1}",bitNumber, value, numExtractingFrom);


    }
}

