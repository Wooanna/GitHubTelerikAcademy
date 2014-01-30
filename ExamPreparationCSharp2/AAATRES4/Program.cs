using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AAATRES4
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            StringBuilder numberDecimal = new StringBuilder();

            while (number > 0)
            {
                numberDecimal.Append( number % 9);
                number = number / 9;
            }
            
            StringBuilder revNum = new StringBuilder();
            for (int i = numberDecimal.Length - 1; i >= 0; i--)
            {
                revNum.Append(numberDecimal[i]);
            }
            //Console.WriteLine(revNum);
            StringBuilder tres = new StringBuilder();
            for (int i = 0; i < revNum.Length; i++)
            {
                switch (revNum[i])
                {
                    case '0': tres.Append("LON+"); break;
                    case '1': tres.Append("VK-"); break;
                    case '2': tres.Append("*ACAD"); break;
                    case '3': tres.Append("^MIM"); break;
                    case '4': tres.Append("ERIK|"); break;
                    case '5': tres.Append("SEY&"); break;
                    case '6': tres.Append("EMY>>"); break;
                    case '7': tres.Append("/TEL"); break;
                    case '8': tres.Append("<<DON"); break;

                    default:
                        break;
                }
            }
            Console.WriteLine(tres);
        }
        

    }
}
