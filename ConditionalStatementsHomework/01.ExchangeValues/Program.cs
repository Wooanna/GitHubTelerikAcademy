using System;

//Write an if statement that examines two integer variables 
//and exchanges their values if the first one is greater than the second one.



    class ExchangeValue
    {
        static void Main()
        {
            Console.WriteLine("Enter Lower number");
            double lower = double.Parse(Console.ReadLine());// 10
            Console.WriteLine("Enter Greater number");
            double greater = double.Parse(Console.ReadLine()); // 5

            if (greater > lower)
            {
                greater = lower + greater;
                lower = greater - lower;
                greater = greater - lower;
            }
            Console.WriteLine("Greater becomes :{0}\n And lower becomes:{1}",greater, lower );
        }
    }

