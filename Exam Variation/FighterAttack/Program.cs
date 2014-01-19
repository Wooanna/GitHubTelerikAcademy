using System;
//PX1, PY1, PX2, PY2, FX, FY, and D


   class FighterAttack
    {
        static void Main()
        {
            int aX1 = int.Parse(Console.ReadLine());
            int aY1 = int.Parse(Console.ReadLine());
            int aX2 = int.Parse(Console.ReadLine());
            int aY2 = int.Parse(Console.ReadLine());
            int FX = int.Parse(Console.ReadLine());
            int FY = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            //int aX1 = 3;
            //int aY1 = 5;
            //int aX2 = 6;
            //int aY2 = 3;
            //int FX = -6;
            //int FY = 3;
            //int D = 9;
            int damage = 0;

           int pX1 = Math.Min(aX1, aX2);
           int pX2 = Math.Max(aX1, aX2);
           int pY1 = Math.Min(aY1, aY2);
           int pY2 = Math.Max(aY1, aY2);



            if (((( FX + D ) >= pX1 )&& ((FX + D) <= pX2 )) && (( FY >= pY1 && FY <= pY2)) )
            {
                damage += 100;
            }
            if ((((FX+D + 1  ) >= pX1 ) && ((FX + D + 1) <= pX2 ))  &&  (( FY >= pY1 && FY <= pY2)) )
            {
                damage += 75;
            }
            if ((((FY + 1) >= pY1 )&& ((FY+ 1) <= pY2) ) && (((FX + D) <= pX2 ) && ((FX + D) >= pX1)))
            {
                damage += 50;
            }
            if ((((FY - 1) >= pY1) && ((FY - 1) <= pY2))  && (((FX + D) <= pX2 ) && ((FX + D) >= pX1)))
            {
                damage += 50;
            }


            Console.WriteLine("{0}%",damage);
        }
    }

