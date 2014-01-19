using System;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math
    class TriangleSurface
    {
        static void Main()
        {
            int choise;
            do
            {
                Console.WriteLine("Choose one of the following options \nfor calculating triangle surface: ");
                Console.WriteLine("Press /1/ for calculating by side and altitude:  ");
                Console.WriteLine("Press /2/ for calculating by three sides:  ");
                Console.WriteLine("Press /3/ for calculating by two sides and angle between them:  ");

            } while (!int.TryParse(Console.ReadLine(), out choise) || (choise != 1 && choise != 2 && choise != 3));

            if (choise == 1)
            {
                float side;
                do
                {
                    Console.Write("Please enter side:");
                } while (!float.TryParse(Console.ReadLine(), out side));
                float altitude;
                do
                {
                    Console.Write("Please enter altitude:");
                } while (!float.TryParse(Console.ReadLine(), out altitude));

                Console.WriteLine(  CalculateTirangleSurface(side, altitude));
            }
            else if (choise == 2) 
            {
                float sideA, sideB, sideC;
                do
                {
                    Console.Write("Please enter side A: ");
                } while (!float.TryParse(Console.ReadLine(), out sideA));
                do
                {
                    Console.Write("Please enter side B: ");
                } while (!float.TryParse(Console.ReadLine(), out sideB));
                do
                {
                    Console.Write("Please enter side C: ");
                } while (!float.TryParse(Console.ReadLine(), out sideC));

                Console.WriteLine(  CalculateTirangleSurface(sideA, sideB, sideC));
            }
            else if (choise == 3)
            {
                float sideA, sideB;
                uint angle;
                do
                {
                    Console.Write("Please enter side A: ");
                } while (!float.TryParse(Console.ReadLine(), out sideA) || sideA <= 0);
                do
                {
                    Console.Write("Please enter side B: ");
                } while (!float.TryParse(Console.ReadLine(), out sideB) || sideB <= 0);
                do
                {
                    Console.Write("Please enter angle: ");
                } while (!uint.TryParse(Console.ReadLine(), out angle) || angle >= 180);

                Console.WriteLine(   CalculateTirangleSurface(sideA, sideB, angle));
            }
        }

        private static float CalculateTirangleSurface(float sideA, float sideB, float sideC)
        {
            float p = (sideA + sideB + sideC) / 2;
            float surface = (float)Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return surface;
        }

        private static float CalculateTirangleSurface(float side, float altitude)
        {
            float surface = (side * altitude) / 2;
            return surface;
        }

        private static float CalculateTirangleSurface(float sideA, float sideB, uint angle)
        {
            float angleRadians = (float)(angle * Math.PI) / 180;
            float surface = (float)Math.Sin(angleRadians) * sideA * sideB;
            return surface;
        }

    }

