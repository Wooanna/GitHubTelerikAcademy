using System;

/* Write an expression that checks if given integer is odd or even
 */
namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {

            while (true)
            {
                Console.Write("Add a number to be checked:");
                string num = Console.ReadLine();
                int number = int.Parse(num);

                bool result = (number % 2 == 0);

                if (result == true)
                {
                    Console.WriteLine("The number {0} is even", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd", number);
                }
                Console.WriteLine();
            }
        }
    }
}
