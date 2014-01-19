using System;


namespace ExchangingValues
{

    /* Declare  two integer variables and assign them with 5 and 10
     * and after that exchange their values. */
    class ExchangingValues
    {
        static void Main()
        {

            int a = 5;
            int b = 10;          

           
            a = a + b;  // a=5+10=15;
            b = a - b;  // b= 15-10=5;
            a = a - b;  // a= 15-5=10;
             Console.WriteLine( "a= {0}, b= {1}", a, b );

        }
    }
}
