using System;
/*Write a boolean expression that checks for given integer 
 * if it can be divided (without remainder) by 7 and 5 in the same time.*/

class DevBy5and7
{
    static void Main()
    {
        Console.Write("Add a number to be checked");
        string num = Console.ReadLine();
        int number = int.Parse(num);

        bool DevByFive = (number % 5 == 0);
        bool DevBySeven = (number % 7 == 0);

        if (DevBySeven && DevByFive == true)
        {
            Console.WriteLine("The Number {0} is devidable by Seven and Five at the same time");
        }
        else
        {
            Console.WriteLine("The number {0} is not devidable by Seven and Five at the same time");
        }
    }
}
    

