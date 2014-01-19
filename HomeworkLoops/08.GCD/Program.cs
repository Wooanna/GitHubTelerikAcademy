using System;
//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
    class GCD
    {
        static void Main()
        {
            Console.WriteLine("Enter Larger Number:");
               int OriginalPairIntLarger = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter Smaller Number:");
            int OriginalPairIntSmaller = int.Parse(Console.ReadLine());
                
           
            
            int REMINDER = OriginalPairIntLarger % OriginalPairIntSmaller;
            



            while (REMINDER != 0)
            {
                OriginalPairIntLarger = OriginalPairIntSmaller;
                 OriginalPairIntSmaller = REMINDER;
                 REMINDER = OriginalPairIntLarger % REMINDER; 
                
            }

            Console.WriteLine("{0}", OriginalPairIntSmaller);
        }
    }

