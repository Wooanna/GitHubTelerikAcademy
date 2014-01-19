using System;
/* Write a method that calculates the number of workdays between
 * today and given date, passed as parameter. Consider that workdays
 * are all days from Monday to Friday except a fixed
 * list of public holidays specified preliminary as array.
 */
class WorkDays
{
    static System.Collections.Generic.List<DateTime> holidays =
         new System.Collections.Generic.List<DateTime>()
        {
            new DateTime(2014, 1, 1),
            new DateTime(2014, 1, 2),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 31)
        };

    static void Main()
    {


        int year, month, day;
        do
        {
            Console.WriteLine("Enter year in the format YYYY: ");
        } while (!int.TryParse(Console.ReadLine(), out year) || year < 1 || year > 9999);
        do
        {
            Console.WriteLine("Enter month in the format MM: ");
        } while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);
        do
        {
            Console.WriteLine("Enter day in the format DD: ");
        } while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31);

        DateTime date = new DateTime(year, month, day);

        CountWorkDays(date, DateTime.Now);

    }

    private static void CountWorkDays(DateTime date, DateTime dateTime)
    {
        int timeLength = 0;
        timeLength = Math.Abs((DateTime.Now - date).Days);
        bool isHoliday = false;
        int numberOfWorkingDays = 0;
        DateTime startDate = DateTime.Today;

        for (int i = 0; i < timeLength; i++)
        {
            startDate = startDate.AddDays(1);
            if (startDate.DayOfWeek != DayOfWeek.Sunday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Count; j++)
                {
                    if (startDate == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (!isHoliday)
                {
                    numberOfWorkingDays++; 
                }
                isHoliday = false;
            }
        }
        Console.WriteLine("Number of working days: {0}", numberOfWorkingDays);
 
    }
}

