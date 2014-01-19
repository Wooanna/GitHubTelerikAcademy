using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TenYearsAfter
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            
            Console.WriteLine("Enter your current age: ");
            int CurrentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age will be {0} in 10 years away from {1}", CurrentAge + 10, DateTime.Now);
            
        }
    }
}
