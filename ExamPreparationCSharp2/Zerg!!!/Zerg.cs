using System;
using System.Text;

    class Zerg
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < input.Length; i += 4)
            {
                string separatedNumber = input.Substring(i, 4);

                switch (separatedNumber)
                {
                    case "Rawr": number.Append("0"); break;
                    case "Rrrr": number.Append("1"); break;
                    case "Hsst": number.Append("2"); break;
                    case "Ssst": number.Append("3"); break;
                    case "Grrr": number.Append("4"); break;
                    case "Rarr": number.Append("5"); break;
                    case "Mrrr": number.Append("6"); break;
                    case "Psst": number.Append("7"); break;
                    case "Uaah": number.Append("8"); break;
                    case "Uaha": number.Append("9"); break;
                    case "Zzzz": number.Append("A"); break;
                    case "Bauu": number.Append("B"); break;
                    case "Djav": number.Append("C"); break;
                    case "Myau": number.Append("D"); break;
                    case "Gruh": number.Append("E"); break;
                }
            }
            Console.WriteLine(From15To10NumeralSys(number));
        }

        private static long From15To10NumeralSys(StringBuilder number)
        {
            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                long power = number.Length - 1 - i;

                int currentChar = number[i] - 48;
                switch (number[i])
                {
                    case '0': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '1': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '2': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '3': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '4': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '5': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '6': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '7': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '8': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case '9': result = result + currentChar * (long)Math.Pow(15, power); break;
                    case 'A': result = result + 10 * (long)Math.Pow(15, power); break;
                    case 'B': result = result + 11 * (long)Math.Pow(15, power); break;
                    case 'C': result = result + 12 * (long)Math.Pow(15, power); break;
                    case 'D': result = result + 13 * (long)Math.Pow(15, power); break;
                    case 'E': result = result + 14 * (long)Math.Pow(15, power); break;
                }
            }
            return result;
        }
    }

