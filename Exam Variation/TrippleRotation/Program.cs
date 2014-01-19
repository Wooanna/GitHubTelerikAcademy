using System;



    class TrippleRotation
    {
        static void Main()
        {

            string number = Console.ReadLine();
            string output;
            char lastChar;

            for (int i = 0; i < 3; i++)
            {
                output = "";
                lastChar = number[number.Length - 1];
                if (lastChar == '0')
                {
                    for (int j = 0; j < number.Length - 1; j++)
                    {
                        output = output + number[j];
                    }
                }
                else
                {
                    output = lastChar + output;
                    for (int j = 0; j < number.Length - 1; j++)
                    {
                        output = output + number[j];
                    }
                }
                number = output;
            }
            Console.WriteLine(number);
        }
    }
        
