using System;

using System.Text;
/*Find online more information about ASCII (American 
 * Standard Code for Information Interchange) and
 * write a program that prints the  entire
 * ASCII table of characters on the console. */


namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (byte b = 0; b < byte.MaxValue; b++)
            {

                char ch = Convert.ToChar(b);
                switch (b)
                {

                    case 8: 
                    
                    case 9:
                    case 10:
                    case 13:

                        ch = '.';

                        break;
                }
                Console.WriteLine("For " + b + " the ASCII table gives: " + (char)b);

                if (b == 7) Console.WriteLine(" ");

                

            }

        }
    }
}
            
        
    

