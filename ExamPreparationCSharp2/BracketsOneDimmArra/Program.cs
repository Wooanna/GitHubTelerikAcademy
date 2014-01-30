using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BracketsOneDimmArra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger[] arr = new BigInteger[input.Length + 2];
            BigInteger[] temp = new BigInteger[input.Length + 2];

            arr[0] = 1;

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 1; k < arr.Length - 1; k++)
                {
                    if (input[i] == '?')
                    {
                        temp[k] = arr[k - 1] + arr[k + 1];

                    }
                    if (input[i ] == '(')
                    {
                        temp[k] = arr[k - 1];
                    }
                    if (input[i ] == ')')
                    {
                        temp[k] = arr[k + 1];
                    }
                    
                }

                arr = temp;
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write("{0, 3}", arr[j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr[1]);
            
        }
    }
}
