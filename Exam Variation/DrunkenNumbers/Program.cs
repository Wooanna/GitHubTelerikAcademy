using System;
using System.Numerics;
    class DrunkenNumbers

    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int digitsCounter = 0; //broi chisla chetno/nechetno
            int beersSeparator = 0; //po kolko chisla shte se broiat za chovek
            int mResult = 0;
            int vResult = 0;


            for (int i = 0; i < N; i++)
            {
                decimal inputNum = decimal.Parse(Console.ReadLine());
                decimal absInput = Math.Abs(inputNum);
                string input = Convert.ToString(absInput);
                if (input.Length % 2 == 0)
                {
                    for (int m = 0; m < input.Length / 2; m++)
                    {
                        mResult += Convert.ToInt32(input[m]) - 48;
                    }
                    for (int v = input.Length/ 2; v < input.Length; v++)
                    {
                        vResult += Convert.ToInt32(input[v]) - 48 ;
                    }
                }
                else if (input.Length % 2 == 1)
                {
                    for (int m = 0; m < (input.Length / 2) + 1; m++)
                    {
                        mResult += Convert.ToInt32(input[m]) - 48;
                    }
                    for (int v = input.Length / 2; v < input.Length; v++)
                    {
                        vResult += Convert.ToInt32(input[v]) - 48 ;
                    }
                }
            }

            int mitkoWinsRes = 0;
            int vladkoWinsRes = 0;
            int tieResult = 0;
            if (mResult > vResult)
            {
                mitkoWinsRes = mResult - vResult;
                Console.WriteLine("M {0}", mitkoWinsRes);
            }
            else if (vResult > mResult)
            {
                vladkoWinsRes = vResult - mResult;
                Console.WriteLine("V {0}", vladkoWinsRes);
            }
            else if(mResult == vResult)
            {
                tieResult = mResult + vResult;
                Console.WriteLine("No {0}", tieResult);
            }

        }
    }

