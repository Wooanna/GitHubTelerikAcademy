using System;

    class ShipDamage
    {
        static void Main()
        {
            //SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, CY3

            int sx1 = Int32.Parse(Console.ReadLine());
            int sy1 = Int32.Parse(Console.ReadLine());
            int sx2 = Int32.Parse(Console.ReadLine());
            int sy2 = Int32.Parse(Console.ReadLine());
            int h = Int32.Parse(Console.ReadLine());
            int cx1 = Int32.Parse(Console.ReadLine());
            int cy1 = Int32.Parse(Console.ReadLine());
            int cx2 = Int32.Parse(Console.ReadLine());
            int cy2 = Int32.Parse(Console.ReadLine());
            int cx3 = Int32.Parse(Console.ReadLine());
            int cy3 = Int32.Parse(Console.ReadLine());

            
            cy1 = 2 * h - cy1;
            cy2 = 2 * h - cy2;
            cy3 = 2 * h - cy3;

            
            int minX = Math.Min(sx1, sx2); //намираме по-голямото/малкото от двете точки и си го слагаме в нова променлива
            int maxX = Math.Max(sx1, sx2);
            int minY = Math.Min(sy1, sy2);
            int maxY = Math.Max(sy1, sy2);

            int totalDamage = 0;

            
            if ((cx1 == minX || cx1 == maxX) && (cy1 == minY || cy1 == maxY))
            {
                totalDamage += 25; 
            }
            if ((cx2 == minX || cx2 == maxX) && (cy2 == minY || cy2 == maxY))
            {
                totalDamage += 25; 
            }
            if ((cx3 == minX || cx3 == maxX) && (cy3 == minY || cy3 == maxY))
            {
                totalDamage += 25; 
            }

           
            if (((cx1 == minX || cx1 == maxX) && (cy1 > minY && cy1 < maxY)) ||
                ((cy1 == minY || cy1 == maxY) && (cx1 > minX && cx1 < maxX)))
            {
                totalDamage += 50; 
            }
            if (((cx2 == minX || cx2 == maxX) && (cy2 > minY && cy2 < maxY)) ||
                ((cy2 == minY || cy2 == maxY) && (cx2 > minX && cx2 < maxX)))
            {
                totalDamage += 50; 
            }
            if (((cx3 == minX || cx3 == maxX) && (cy3 > minY && cy3 < maxY)) ||
                ((cy3 == minY || cy3 == maxY) && (cx3 > minX && cx3 < maxX)))
            {
                totalDamage += 50; 
            }

            
            if ((cx1 > minX) && (cx1 < maxX) && (cy1 > minY) && (cy1 < maxY))
            {
                totalDamage += 100; 
            }
            if ((cx2 > minX) && (cx2 < maxX) && (cy2 > minY) && (cy2 < maxY))
            {
                totalDamage += 100; 
            }
            if ((cx3 > minX) && (cx3 < maxX) && (cy3 > minY) && (cy3 < maxY))
            {
                totalDamage += 100; 
            }

            Console.WriteLine("{0}%", totalDamage);

        }
    }

