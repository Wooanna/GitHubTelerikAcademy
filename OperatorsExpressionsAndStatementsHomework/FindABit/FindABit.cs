using System;

/*Write a boolean expression that returns if the bit at position p (counting from 0)
 * in a given integer number v has value of 1. Example: v=5; p=1  false.

 */
namespace FindABit
{
    class FindABit
    {
        static void Main()
        {
            int position = 0;                                //position counting from 0
            int number = 1;                                   // binary  000000001
            int mask = 1 << position;                             /* Creating a new num,witch we call"mask" with value 1. 
                                                                   * From 00001 it becomes to 0000010.*/
            int numberAndMask = number & mask;                       /* Compareson of number and the mask with ''&'' bitwise operator */
            int bit = numberAndMask >> position;

            bool result = (bit == 1);


            Console.WriteLine(result);

            
        }
    }
}
