using System;
//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.


namespace DoubleIntOrString
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var variable = Console.ReadLine();
                double variableInt = 0;
                bool integOrDouble = double.TryParse(variable, out variableInt);
                bool integerOrDouble = ((variableInt < double.MaxValue) && (variableInt > double.MinValue));

                if (integOrDouble && integerOrDouble == true)
                {
                    variableInt++;
                    Console.WriteLine(variableInt);
                }
                else
                {
                    variable += "*";
                    Console.WriteLine(variable);
                }
            }
           
                 


        }
    }
}
