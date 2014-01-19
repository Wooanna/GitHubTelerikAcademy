using System;


namespace LastMajorityMultiple
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d, e;
            

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int max = 100 * 100 * 100;
            for (int number = 4; number < max; number++)
            {

                int devidorsCount = 0;
                if (number % a == 0)
                {
                    devidorsCount++;

                }
                if (number % b == 0)
                {
                    devidorsCount++;

                }
                if (number % c == 0)
                {
                    devidorsCount++;

                }
                if (number % d == 0)
                {
                    devidorsCount++;

                }
                if (number % e == 0)
                {
                    devidorsCount++;

                }

                if (devidorsCount >= 3)
                {
                    Console.WriteLine(number);
                    break;
                }
                
            }
        }
    }
}
