using System;
using System.Numerics;
    class AirplaneDrink
    {
        static void Main()
        {
            int seatsN = 7;
            int numSeatsWithTea = 2;

            int teaSeat = 2;
            int seatTea = 3;

            BigInteger seconds = 0;
            int refills = (seatsN / 7)  + 1;
            int teaRefills = 0;
            if (numSeatsWithTea <= 7)
            {
                teaRefills = 1;
            }
            else if (numSeatsWithTea > 7)
            {
                if (numSeatsWithTea % 7 == 0)
                {
                    teaRefills = numSeatsWithTea / 7;
                }
                else
                {

                }
                
            }


            



            for (int j = 0; j < refills/* Kolko pati se vrashta*/; j++)
            {
                seconds += 47;

                for (int i = 0; i <= seatsN; i++)
                {

                    seconds++;
                    if (i == teaSeat || i == seatTea)
                    {
                        seconds += 4;
                    }
                }
            }
        }
    }

