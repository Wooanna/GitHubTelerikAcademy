using System;



    class Program
    {
        static void Main(string[] args)
        {
            decimal tomatoSeed = decimal.Parse(Console.ReadLine());
            decimal tomatoArea = decimal.Parse(Console.ReadLine());

            decimal cucumberSeed = decimal.Parse(Console.ReadLine());
            decimal cucumberArea = decimal.Parse(Console.ReadLine());

            decimal potatoSeed = decimal.Parse(Console.ReadLine());
            decimal potatoArea = decimal.Parse(Console.ReadLine());

            decimal carrotSeed = decimal.Parse(Console.ReadLine());
            decimal carrotArea = decimal.Parse(Console.ReadLine());

            decimal cabageSeed = decimal.Parse(Console.ReadLine());
            decimal cabageArea = decimal.Parse(Console.ReadLine());

            decimal beanSeed = decimal.Parse(Console.ReadLine());


            decimal tomatoPrice = tomatoSeed * 0.5M;
            decimal cucumberPrice = cucumberSeed * 0.4M;
            decimal potatoPrice = potatoSeed * 0.25M;
            decimal carrotPrice = carrotSeed * 0.6M;
            decimal cabbagePrice = cabageSeed * 0.3M;
            decimal beanPrice = beanSeed * 0.4M;

            decimal totalCost = tomatoPrice + cucumberPrice + potatoPrice + carrotPrice
                + cabbagePrice + beanPrice;


            Console.WriteLine("Total costs: " + totalCost);
             decimal leftArea = 250 - (tomatoArea + potatoArea + cucumberArea + carrotArea +
                 cabageArea) ;
             if (leftArea < 0)
             {
                 Console.WriteLine("Insufficient area");
             }
             else if (leftArea == 0)
             {
                 Console.WriteLine("No area for beans");
             }
             else
             {
                 Console.WriteLine("Beans area: {0}", leftArea);
             }


        }
    }

