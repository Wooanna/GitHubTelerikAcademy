using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTry
{
    class Program
    {

        static void printMatirx(int start, int end)
        {
            
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0}", i);
            }
        }
        static void Main(string[] args)
        {   int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                printMatirx(1, i);
                Console.WriteLine();
            }

            for (int i = n - 1; i > 0; i--)
            {
                printMatirx(1, i);
                Console.WriteLine();
            } 
        }
    }
}
