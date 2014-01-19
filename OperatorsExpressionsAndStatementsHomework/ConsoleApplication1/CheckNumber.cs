using System;
/*Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

 */
    class CheckNumber
    {
        static void Main()
        {
            Console.WriteLine("Please enter a Four Digit number to be checked:");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            double reminder = number % 1000;
            bool Greater = (reminder >= 700);
            bool Lower = (reminder <= 799);

            if (Greater && Lower == true)
            {
                Console.WriteLine("The third Digit is 7");
            }
            else 
            {
                Console.WriteLine("The third digit is not 7");
            }          
            
        }
    }

