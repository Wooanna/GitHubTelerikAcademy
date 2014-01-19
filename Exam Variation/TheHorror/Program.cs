using System;
using System.Numerics;


namespace TheHorror
{
    class Program
    {
        static void Main()
        {


            string text = Console.ReadLine();


            BigInteger result = 0;
            BigInteger counter = 0;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    continue;
                }
                else if (char.IsDigit(text[i]))
                {
                    if (i % 2 == 0)
                {

                    result += Convert.ToInt32(text[i]) - 48;
                    counter++;
                }
                }
                
            }

            Console.WriteLine("{0} {1}", counter, result);


        }
    }
}
