using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KaspichanLetters
{
    class KaspichanLetters
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string result = string.Empty;
            while (number > 0)
            {
                result = ToKaspichan(number % 256) + result;
                number = number / 256;

            }
            Console.WriteLine(result);
        }

        private static string ToKaspichan(ulong p)
        {
            string s = "" + (char)(p % 26 + 65);
            p /= 26;
            if (p > 0)
            {
                s = (char)(p + 96) + s;
            }
            return s;

        }
    }
}
