using System;


namespace PrimeOrNot
{
    class PrimeOrNot
    {
        static void Main()
        {

            while (true)
            {
                
            
            Console.WriteLine("Enter a number to check:");
            int number = Convert.ToInt32(Console.ReadLine());


            bool isPrime = (number % 2 == 0);

            if (isPrime == false)
            {
                Console.WriteLine("The number {0} is Prime", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not Prime", number);
            }
            }
        }
    }
}
