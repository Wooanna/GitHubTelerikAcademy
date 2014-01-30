using System;
//Write program that asks for a digit and depending on the input
//shows the name of that digit (in English) using a switch statement.

class ShowDigitWithAWord
{
static void Main()
{
    Console.WriteLine("Enter a digit to be represented [0..9]");
    byte b = byte.Parse(Console.ReadLine());
            
        switch (b)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Tree"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
        }
    }
}
    

