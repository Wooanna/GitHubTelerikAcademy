using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class MultiverseCommunication
    {
        static void Main()
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            string input = Console.ReadLine();
            StringBuilder number = new StringBuilder();


            for (int i = 0; i < input.Length; i+= 3)
            {
                string separatedToken = input.Substring(i, 3);
               
                switch (separatedToken)
                {
                    case "CHU": number.Append('0'); break;
                    case "TEL": number.Append('1'); break;
                    case "OFT": number.Append('2'); break;
                    case "IVA": number.Append('3'); break;
                    case "EMY": number.Append('4'); break;
                    case "VNB": number.Append('5'); break;
                    case "POQ": number.Append('6'); break;
                    case "ERI": number.Append('7'); break;
                    case "CAD": number.Append('8'); break;
                    case "K-A": number.Append('9'); break;
                    case "IIA": number.Append('A');break;
                    case "YLO": number.Append('B');break;
                    case "PLA": number.Append('C'); break;

                }


            }
            Console.WriteLine(From13To10(number));

        }

        private static long From13To10(StringBuilder number)
        {
            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case '0':      result = result + 0 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '1':  result =result +  1 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '2':  result =result +  2 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '3':  result =result +  3 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '4':  result =result +  4 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '5':  result =result +  5 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '6':  result =result +  6 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '7':  result =result +  7 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '8':  result =result +  8 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case '9':  result =result +  9 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case 'A': result = result + 10 * (long)Math.Pow(13, number.Length - 1 - i); break;
                        case 'B': result = result + 11 * (long)Math.Pow(13, number.Length - 1 - i);break;
                        case 'C': result = result + 12 * (long)Math.Pow(13, number.Length - 1 - i); break;
                    
                }
            }
            return result;
        }
    }
}
