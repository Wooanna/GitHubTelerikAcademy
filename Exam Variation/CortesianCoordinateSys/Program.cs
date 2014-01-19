using System;

    class CortesianCoordinateSys
    {
        static void Main()
        {
            decimal X = decimal.Parse(Console.ReadLine());
            
            decimal Y = decimal.Parse(Console.ReadLine());

            //0 = v sredata
            // 1 = x> 0, y > 0
            //2 = x < 0 , y > 0
            //3 = x < 0, y <0
            //4 = x> 0, y < 0
            //5 = x = 0
            // 6 = y = 0

            if (X == 0)
            {
                if (Y == 0)
                {
                    Console.WriteLine(0);
                }
                else 
                Console.WriteLine(5);
            }
            else if  (Y == 0)
            {
                if (X == 0)
                {
                    Console.WriteLine(0);
                }
                
                Console.WriteLine(6);
            }
            else if( X > 0 && Y > 0)
            {
                Console.WriteLine(1);
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine(2);
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine(3);
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine(4);
            }
        }
    }

