using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

    class Reverse
    {
        static void Main(string[] args)
        {
            string yourText = Console.ReadLine();
            //char[] reversed = yourText.ToCharArray();
            //Array.Reverse(charText);
            StringBuilder reversed = new StringBuilder();
            for (int i = yourText.Length - 1; i >= 0; i--)
			{
			 reversed.Append(yourText[i]);
			}
            Console.WriteLine(reversed);
        }
    }

