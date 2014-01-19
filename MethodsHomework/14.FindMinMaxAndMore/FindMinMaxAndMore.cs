using System;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.


class FindMinMaxAndMore
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        MinOrMax(a, b, c, d);
        Average(a, b, c, d);
        Sum(a, b, c, d);
        Product(a, b, c, d);

    }

    private static void Product(int a, int b, int c, int d)
    {
        Console.WriteLine("The product is {0}", a * b * c * d);
    }

    private static void Sum(int a, int b, int c, int d)
    {
        Console.WriteLine("The sum of all numbers is: {0}", a + b + c + d);
    }

    private static void Average(int a, int b, int c, int d)
    {
        Console.WriteLine("The average value of all numbers is: {0}", (a + b + c + d) / 2);
    }

    private static void MinOrMax(int a, int b, int c, int d)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        if (a < min) min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;

        Console.WriteLine("Min is {0} and Max is {1}", min, max);
    }
}

