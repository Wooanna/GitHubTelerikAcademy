using System;
using System.Text;

class BinaryToHexadecimal
{
  
    static void Main()
    {
        string binaryNum = Console.ReadLine();

        
        Console.WriteLine(BinaryToHex(binaryNum));
    }

    static string BinaryToHex(string binaryNum)
    { 
         StringBuilder stringBuild = new StringBuilder();

        if (binaryNum.Length % 4 != 0)
        {
            binaryNum = binaryNum.PadLeft(binaryNum.Length + (4 - (binaryNum.Length % 4)), '0');
            
        }
        for (int i = 0; i < binaryNum.Length; i+=4)
        {
            string currentFour = binaryNum.Substring(i, 4);
            switch (currentFour)
            {
                case "0000": stringBuild.Append('0'); break;
                case "0001": stringBuild.Append('1'); break;
                case "0010": stringBuild.Append('2'); break;
                case "0011": stringBuild.Append('3'); break;
                case "0100": stringBuild.Append('4'); break;
                case "0101": stringBuild.Append('5'); break;
                case "0110": stringBuild.Append('6'); break;
                case "0111": stringBuild.Append('7'); break;
                case "1000": stringBuild.Append('8'); break;
                case "1001": stringBuild.Append('9'); break;
                case "1010": stringBuild.Append('A'); break;
                case "1011": stringBuild.Append('B'); break;
                case "1100": stringBuild.Append('C'); break;
                case "1101": stringBuild.Append('D'); break;
                case "1110": stringBuild.Append('E'); break;
                case "1111": stringBuild.Append('F'); break;
                default:
                    throw new ArgumentException("Invalid input");
            }
        }
        return stringBuild.ToString();
    }
}