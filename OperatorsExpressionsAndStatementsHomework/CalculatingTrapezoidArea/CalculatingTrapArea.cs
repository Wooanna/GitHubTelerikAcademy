using System;



    class CalculatingTrapArea

    {
        static void Main()
        {

            /*Write an expression that calculates trapezoid's
            area by given sides a and b and height h.*/

            int ABside = 5;
            int CDside = 7;
            int h = 2;

            int area = h * ((ABside + CDside) / 2);

            Console.WriteLine("The area of Trapezoid with sides 7 and 13, and Height 7 is {0}", area);

        }
    }

