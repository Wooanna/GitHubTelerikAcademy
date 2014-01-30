using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


    class nineGagNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string currentNumber = string.Empty;
            string nineGagNumber = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
               nineGagNumber += input[i];
               switch (nineGagNumber)
               {

                    case "-!"     : currentNumber += "0"; nineGagNumber = string.Empty; break;
                    case "**"     : currentNumber += "1"; nineGagNumber = string.Empty; break;
                    case "!!!"    : currentNumber += "2"; nineGagNumber = string.Empty; break;
                    case "&&"     : currentNumber += "3"; nineGagNumber = string.Empty; break;
                    case "&-"     : currentNumber += "4"; nineGagNumber = string.Empty; break;
                    case "!-"     : currentNumber += "5"; nineGagNumber = string.Empty; break;
                    case "*!!!"   : currentNumber += "6"; nineGagNumber = string.Empty; break;
                    case "&*!"    : currentNumber += "7"; nineGagNumber = string.Empty; break;
                    case "!!**!-": currentNumber += "8"; nineGagNumber = string.Empty;  break;
                         
                   default:
                       currentNumber += string.Empty;
                       break;
               }
            }

            Console.WriteLine(FromNineGagToDecimal(currentNumber));
        }

        private static BigInteger FromNineGagToDecimal(string currentNumber)
        {
            
            BigInteger numberInDecimal = 0;
            for (int i = 0; i < currentNumber.Length; i++)
            {
                switch (currentNumber[i])
                {
                        case '0' : numberInDecimal +=  BigInteger.Parse("0")* GetPower(currentNumber.Length - i - 1);  break;
                        case '1' : numberInDecimal +=  BigInteger.Parse("1")* GetPower(currentNumber.Length - i - 1);  break;
                        case '2' : numberInDecimal +=  BigInteger.Parse("2")* GetPower(currentNumber.Length - i - 1);  break;
                        case '3' : numberInDecimal +=  BigInteger.Parse("3")* GetPower(currentNumber.Length - i - 1);  break;
                        case '4' : numberInDecimal +=  BigInteger.Parse("4")* GetPower(currentNumber.Length - i - 1);  break;
                        case '5' : numberInDecimal +=  BigInteger.Parse("5")* GetPower(currentNumber.Length - i - 1);  break;
                        case '6' : numberInDecimal +=  BigInteger.Parse("6")* GetPower(currentNumber.Length - i - 1);  break;
                        case '7':  numberInDecimal +=  BigInteger.Parse("7") * GetPower(currentNumber.Length - i - 1); break;
                        case '8':  numberInDecimal +=  BigInteger.Parse("8") * GetPower(currentNumber.Length - i - 1); break;

                    default:
                        break;
                }
            }
            return numberInDecimal;
        }

        private static BigInteger GetPower(int position)
        {
            BigInteger power = 1;
            for (int i = 0; i < position; i++)
            {
                power *= 9;
            }
            return power;
        }
    }
