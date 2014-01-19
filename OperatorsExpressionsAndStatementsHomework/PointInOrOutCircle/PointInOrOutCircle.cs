using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

namespace PointInOrOutCircle
{
    class PointInOrOutCircle
    {
        static void Main()
        {
            Console.WriteLine("Px =");
            string sPointX = Console.ReadLine();
            int PointX;
            int.TryParse(sPointX, out PointX);

            Console.WriteLine("Py =");
            string sPointY = Console.ReadLine();
            int PointY;
            int.TryParse(sPointY, out PointY);
            
            bool InCircle = ((PointX <= 5) && (PointX >= -5 )) && ((PointY <=5) && (PointY >= -5));

            if (InCircle)
            {
                Console.WriteLine("The point is in Circle");
            }
            else
            {
                Console.WriteLine("The point is Out of Circle");
            }
        }
    }
}
