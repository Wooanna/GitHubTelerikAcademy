using System;
//Write a program that enters the coefficients a, b and c of a quadratic equation
//	a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that 
//quadratic equations may have 0, 1 or 2 real roots
// discriminant = b * b - 4 * a * c
namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.Write(  "Please enter value for 'a' :\n//'a' can not be 0//");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter value for 'b' :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter value for 'c' :");
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;


            if (a == 0)
            {
                Console.WriteLine("'a' can not be 0, this is not a quadratic equation. \nYou have no real roots in this case");
            }
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("There are two real roots - x1: {0} and x2: {1}", x1, x2);
            }
            if (discriminant == 0)
            {
                double x1 = -(b / 2 * a);
                Console.WriteLine("There is one real root - x1: {0}", x1);
            }
            if (discriminant < 0)
            {
                Console.WriteLine("The roots are Imaginary Numbers");
            }




        }
    }
}
