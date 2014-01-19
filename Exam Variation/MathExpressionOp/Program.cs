using System;

    class MathExpressionOp
    {
        static void Main()
        {
            decimal  N = decimal.Parse(Console.ReadLine());
            decimal  M = decimal.Parse(Console.ReadLine());
            decimal  P = decimal.Parse(Console.ReadLine());
        
            decimal  dominator = N * N + (1 / (M * P)) + 1337m;
            decimal  nominator = N - (128.523123123m * P);
            decimal  addition = ((int)M % 180m);
            decimal angle = (decimal)Math.Sin((double)addition);

            decimal result = (decimal)((dominator / nominator) + angle);
            Console.WriteLine("{0:0.000000}",result);
        }
    }

