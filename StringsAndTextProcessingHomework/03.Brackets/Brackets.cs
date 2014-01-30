using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


    class Brackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int depth = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    depth++;
                }
                else if (expression[i] == ')')
                {
                    depth--;
                }
            }
            if (depth == 0 )
            {
                Console.WriteLine("Expression is correct");
            }
            else
            {
                Console.WriteLine("Expression is not correct");
            }

        }
    }

