using System;



class PrecisionCompareson
{
    static void Main()
    {



        float a = 5.123453f; 
        float b = 5.123451f;
        float d = Math.Abs(b - a);
        bool result = (d <= 0.000001f);
        Console.WriteLine(result);


        {

        }
    }
}
