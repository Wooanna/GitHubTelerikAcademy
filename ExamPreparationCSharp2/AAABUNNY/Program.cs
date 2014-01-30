using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AAABUNNY
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            StringBuilder cages = new StringBuilder();
            

                while (input != "END")
                {
                    input = Console.ReadLine();
                    cages.Append(input);
                    cages.Append(" ");

                }
                cages.Remove(cages.Length - 5, 4);
                string[] numbersStr = cages.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] cagesI = new int[numbersStr.Length];

                for (int i = 0; i < numbersStr.Length; i++)
                {
                    cagesI[i] = int.Parse(numbersStr[i]);
                }
                Proccess(cagesI, cages);

        }

        private static void Proccess(int[] cagesI, StringBuilder cages)
        {
            StringBuilder cycle = new StringBuilder();
            int cycles = 1;
            
            int sum = 0;
            while (true)

            {
                sum = 0;
                for (int i = 0; i < cycles; i++)
                {
                    sum += cagesI[i];
                    
                }
                if (sum > cagesI.Length)
                {
                    break;
                }
                int sumOfCages = 0;
                BigInteger multiplOfCages = 1;
                for (int summ = cycles; summ < sum + cycles; summ++)
                {
                    sumOfCages += cagesI[summ];
                    multiplOfCages *= cagesI[summ];
                }
                
                cycle.Append(sumOfCages);
                cycle.Append(multiplOfCages);
                int cagesLength = cages.Length -1 ;

                for (int i = 0; i < 20; i++)
                {
                    if (cages[i] == ' ')
                    {
                        cages.Remove(i, 1);
                        cagesLength = cages.Length - 1;
                        //cagesLength--;

                    }
                    if (i >= cagesLength)
                    {
                        break;
                    }
                }
                cagesLength = cages.Length;

                for (int i = cycles + sum; i < cages.Length; i++)
                {
                    cycle.Append(cages[i]);
                }

                int cycleL = cycle.Length - 1;
                //Console.WriteLine(cycle);
                for (int i = 0; i < 20; i++)
                {
                    if (cycle[i] == '0' || cycle[i] == '1')
                    {
                        cycle.Remove(i, 1);
                        cycleL = cycle.Length - 1;
                        i--;
                        //cagesLength--;
                        
                    }
                    if (i >= cycleL)
                    {
                        break;
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    if (cages[i] == '0' || cages[i] == '1')
                    {
                        cages.Remove(i, 1);
                        cagesLength = cages.Length - 1;
                        i--;
                        //cagesLength--;

                    }
                    if (i >= cycleL)
                    {
                        break;
                    }
                }
                cycleL = cycle.Length;
                cages.Clear();
                cages.Append(cycle);
                cycle.Clear();



                
                
                for (int i = 0; i < cages.Length; i++)
                {
                    cagesI[i] = int.Parse(cages[i].ToString());
                }
                cycles++;
            }

            for (int i = 0; i < cages.Length; i++)
            {
                Console.Write(cages[i] + " ");
               
            }
        }
    }
}
