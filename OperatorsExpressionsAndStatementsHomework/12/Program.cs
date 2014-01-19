using System;

/*We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v at the position p 
 * from the binary representation of n.
 * */

class Program
{
    static void Main()
    {
        int position, value, number;
        Console.WriteLine(  "Position");
        position = int.Parse(Console.ReadLine());
        Console.WriteLine(  "value?");
        value = int.Parse(Console.ReadLine()); // 1or 0
        Console.WriteLine(  "Number?");
        number = int.Parse(Console.ReadLine());


        Console.Write("The value {0}, is being put on position {1} in the number {2} \nin its binary representation", value, position, number);
        Console.WriteLine(Convert.ToString(number, 2));

        if (value == 1)
        {
            int Pmask = value << position;
            int generatedNumber = Pmask | number;
            Console.WriteLine("The result of this operation is {0} and its binary representation is:", generatedNumber);
            Console.WriteLine(Convert.ToString(generatedNumber, 2));
        
        }
        if (value == 0)
        {
            int Pmask = 1 << position;
            int generated= ~Pmask & number;
            Console.WriteLine("The result of this operation is {0} and its binary representation is:", generated);
            Console.WriteLine(Convert.ToString(generated, 2));

        }

        
        



    }
}

