using System;
using System.Threading;
using System.Globalization;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        double N1 = double.Parse(Console.ReadLine()); //0.05
        double N2 = double.Parse(Console.ReadLine()); // 0.10
        double N3 = double.Parse(Console.ReadLine()); //0.20
        double N4 = double.Parse(Console.ReadLine()); // 0.50
        double N5 = double.Parse(Console.ReadLine()); //1.00
        double AmountPutted = double.Parse(Console.ReadLine());
        double Price = double.Parse(Console.ReadLine());

        double calcN1 = N1 * 0.05;
        double calcN2 = N2 * 0.10;
        double calcN3 = N3 * 0.20;
        double calcN4 = N4 * 0.50;
        double calcN5 = N5 * 1.00;
        double AmountInTheMachine = calcN1 + calcN2 + calcN3 + calcN4 + calcN5;
        double ChangeNeeded = AmountPutted - Price;




        if ((AmountInTheMachine < ChangeNeeded))
        {
            Console.WriteLine("No {0:0.00}", ChangeNeeded - AmountInTheMachine);

        }
        if (AmountPutted < Price)
        {
            Console.WriteLine("More {0:0.00}", Price - AmountPutted);
        }
        if ((AmountPutted >= Price) && (AmountPutted >= ChangeNeeded))
        {

            Console.WriteLine("Yes {0:0.00}", (AmountInTheMachine - (AmountPutted - Price)));
        }



    }
}

