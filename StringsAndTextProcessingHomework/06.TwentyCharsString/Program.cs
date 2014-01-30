using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class TwentyCharsString
    {
        static void Main()
        {
            string text;
            do
            {
                Console.WriteLine("Enter your text here:");
                text = Console.ReadLine();
                
            } while (text.Length > 20);

            Console.WriteLine(text.PadLeft(20, '*'));

        }
    }

