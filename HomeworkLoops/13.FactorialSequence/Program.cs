using System;
using System.Numerics;
/* * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4 */



    class FactorialSequence
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            int counter = 0;

            for (int i = 1; i <= N; i++)
            {
                nFactorial *= i;
            }

           string strFactorial =  Convert.ToString(nFactorial);

           for (int i = strFactorial.Length - 1; i >= 0; i--)   //Броят се нулите отзад напред!!! Докато се стигне до число != 0. Цикъла прекъсва.
           {

               if (strFactorial[i] == '0')
               {
                   counter++;
               }
               else if (strFactorial[i] != '0') 
               {
                   break;
               }
           }
           Console.WriteLine(nFactorial); // Извежда се резултат.
           Console.WriteLine(counter);
        }
    }

