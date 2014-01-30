using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> sortedNumbers = new SortedSet<int>();
            sortedNumbers.Add(9);
            sortedNumbers.Add(9);
            sortedNumbers.Add(1);
            sortedNumbers.Add(2);

            foreach (var item in sortedNumbers)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
