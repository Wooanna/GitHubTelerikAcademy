using System;


namespace DancingBits
{
    class Program
    {
        static void Main()
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            string wholeSequence ="";
            for (int i = 0; i < N; i++ )
            {
                 int number = int.Parse(Console.ReadLine());

                 wholeSequence = wholeSequence + Convert.ToString(number, 2);
            }
            //int a = 5;
            //int b = 6;
            //int c = 14;
            //int d = 143;

            //string strA = Convert.ToString(a, 2);
            //string strB = Convert.ToString(b, 2);
            //string strC = Convert.ToString(c, 2);
            //string strD = Convert.ToString(d, 2);

            

            int dancingBits = 0;
            char previousChar = wholeSequence[0];
            int count = 1;

           // Console.WriteLine(wholeSequence);

            for (int i = 1; i < wholeSequence.Length ; i++)
            {
                if (wholeSequence[i] == previousChar)
                {
                    count++;
                }
                else
                {
                    if (count == K)
                    {
                        dancingBits++;
                    }
                    count = 1;
                    previousChar = wholeSequence[i];
                }
            }
            if (count == K)
              {
                  dancingBits++;
              }
            Console.WriteLine(dancingBits);
        }
         
    }
}
