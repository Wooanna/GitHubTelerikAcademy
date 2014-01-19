using System;

//Write an expression that calculates rectangle’s area by given width and height.


namespace RectangleAreaCalculating
{
    class RecAreaCalculating
    {
        static void Main()
        {
            Console.WriteLine("Width = ");
            string sWidth = Console.ReadLine();
            long width;
            long.TryParse(sWidth, out width);

            Console.WriteLine("Height = ");
            string sHeight = Console.ReadLine();
            long height;
            long.TryParse(sHeight, out height);

            long area = width * height;

            Console.WriteLine("The area of rectangle with height {0} and width {1} is = {2}", height, width, area);


        }
    }
}
