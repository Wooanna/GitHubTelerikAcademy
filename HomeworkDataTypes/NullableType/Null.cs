using System;
/*Create a program that assigns null values to an integer and to double variables. 
 * Try to print them on the console, try to add some values or the null 
 * literal to them and see the result.*/

    class Null
    {
        static void Main(string[] args)
        {

            int? i = null;
            Nullable<double> d = null;
            double? dNull = d;

            Console.WriteLine("{0} {1} {2}", i, d, dNull);

            

            Console.WriteLine("Null value Prints" + d + i + dNull + "Nothing");

            int integer = 5;
            i = integer;
            double @double = 5;
            dNull = @double;
            int? g = 33;
            Console.WriteLine("{0} {1} {2}", g, integer, @double); 
            //<---------------------------------------------------------------------------->\\
            //<---------------------------------------------------------------------------->\\

            Nullable<double> d1 = null;
            Nullable<int> i1 = null;
            int? i2 = 2;
            i1 = i2;
            Console.WriteLine(i2.HasValue); //True
            Console.WriteLine(d1.HasValue); //False

            d1 = i2.Value;
            Console.WriteLine(d1);

            double? d3 = null;
            d1 = d3.GetValueOrDefault();
            Console.WriteLine(d1);

            

            
                 




        }
    }

