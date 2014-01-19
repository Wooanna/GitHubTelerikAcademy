using System;
/*Write an expression that checks for given point (x, y) 
 * if it is within the circle K( (1,1), 3)
 * and out of the rectangle R(top=1, left=-1, width=6, height=2). */



namespace CrossingCircleAndRectangle
{
    class CrossingCircleAndRectangle
    {
        static void Main()
        {
            while (true)
            {


                Console.WriteLine("Px =");
                string sPointX = Console.ReadLine();
                int PointX;
                int.TryParse(sPointX, out PointX);

                Console.WriteLine("Py =");
                string sPointY = Console.ReadLine();
                int PointY;
                int.TryParse(sPointY, out PointY);

                bool WithinCircle = ((PointX >= -2) && (PointX <= 4)) && ((PointY >= -2) && (PointY <= 4));
                bool WithinRectangle = ((PointX >= -1) && (PointX <= 5)) && ((PointY >= -1) && (PointX <= 1));

                if (WithinCircle)
                {
                    Console.WriteLine("The Point is withing Circle ");

                }
                else
                {
                    Console.WriteLine("The point is out of Circle");
                }

                if (WithinRectangle)
                {
                    Console.WriteLine("...and within Rectangle");
                }
                else
                {
                    Console.WriteLine("...and out of Rectangle");
                }
              }
        }
    }
}
