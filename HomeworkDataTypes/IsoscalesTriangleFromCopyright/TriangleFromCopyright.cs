using System;




    class IsoscalesTriangleFromCopyright
    {
        static void Main()
        {

            char character = '\u00A9';
            

            for (int row = 0; row  < 10; row++)
            {
                Console.Write(new String(' ', 10-row));
                for (int col = 0; col < row; col++)
                {
                    Console.Write("{0} ", character);
                }
                Console.WriteLine();
            }
        }
    }
 

