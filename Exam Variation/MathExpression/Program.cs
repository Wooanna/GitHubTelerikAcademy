using System;
using System.Threading;
using System.Globalization;


namespace MathExpression
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            string readStr = Console.ReadLine();
          decimal N = decimal.Parse(readStr);
            string readStri = Console.ReadLine();
            decimal M = decimal.Parse(readStri);
            string readString = Console.ReadLine();
            decimal P = decimal.Parse(readString);

             decimal angle = ((int)M)% 180;
             angle = (decimal)Math.Sin((double)angle);

            decimal result = ((N * N) + (1 / (M * P)) + 1337m) /
               (N - 128.523123123m * P) + angle;

            Console.WriteLine("{0:0.000000}",result);
        }
    }
}
