using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CalcDays
{
    class CalcDays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write The First date (dd.mm.yyy format): ");
            string input1Raw = Console.ReadLine();

            Console.WriteLine("Write The Second date (dd.mm.yyy format): ");
            string input2Raw = Console.ReadLine();

            string[] Date1 = input1Raw.Split('.');
            string[] Date2 = input2Raw.Split('.');

            DateTime start = new DateTime(int.Parse(Date1[2]), int.Parse(Date1[1]), int.Parse(Date1[0]));
            DateTime end = new DateTime(int.Parse(Date2[2]), int.Parse(Date2[1]), int.Parse(Date2[0]));

            int daysBetween = (int)(end - start).TotalDays;
            Console.WriteLine("Distance: {0} days", daysBetween);

        }
    }
}
