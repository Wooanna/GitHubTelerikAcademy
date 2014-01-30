using System;

//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.
class ShowSigns
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a < 0 || b < 0 || c < 0)
        {
            Console.WriteLine("This is a - product");
        }
        else if ((a > 0 && b > 0 && c > 0))
        {
            Console.WriteLine("This is a + product");
        }
        else if (((a > 0 && (b < 0 && c < 0)) || (b > 0 && (c < 0 && a < 0))) || (c > 0 && (a < 0 && b < 0)))
        {
            Console.WriteLine("This i s a + product");
        }
        else if (((a < 0 && (b > 0 && c > 0)) || (b < 0 && (c > 0 && a > 0))) || (c < 0 && (a > 0 && b > 0)))
        {

            Console.WriteLine("This i s a - product");
        }

    }
}

