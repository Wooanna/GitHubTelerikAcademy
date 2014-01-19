using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class Program
    {
        static void Main()
        {
            int x = 1;
            int y = -2;
            
            for (int i = 1; i < 10; i++, i++)
			{
                Console.WriteLine(x + i);
                Console.WriteLine(y - i);
			}
        }
    }
}
