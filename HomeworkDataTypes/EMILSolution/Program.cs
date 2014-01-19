using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    
            /*Write a program that safely compares floating-point
 * numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false; 
 * (5.00000001 ; 5.00000003)  true */


class Comparison
{
    static void Main()
    {
        while (true)
        {
            
        
        Console.Write("Input First Number: ");
        string a = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Input Second Number: ");
        string b = Console.ReadLine();
        float firstNumber;
        float secondNumber;

        if (float.TryParse(a, out firstNumber) == false || float.TryParse(b, out secondNumber) == false)
        {
            Console.WriteLine("Not a valid Input");
        }
        else
        {
            bool result = Math.Abs(firstNumber - secondNumber) < 0.000001f;
            Console.WriteLine();
            Console.WriteLine("Are they equal? {0}", result);
        }
        }
    }
}
        
 

