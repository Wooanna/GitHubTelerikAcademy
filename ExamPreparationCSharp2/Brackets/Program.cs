using System;
using System.Collections.Generic;
using System.Text;


class Program
{

    public static char[] input;
    public static int counter = 0;


    public static void AddBracket(int depth, int index)
    {
        Console.WriteLine("->{0} {1} {2}",depth, index, new string(input));
        if ( index == input.Length)
        {
            if (depth == 0)
            {
                counter++;
                // Console.WriteLine(new string(input));
            }
            return;
        }

        if (input[index] == '(')
        {
            depth++;
            AddBracket(depth, index + 1);
        }
        else if (input[index] == ')')
        {
            depth--;
            AddBracket(depth, index + 1);
        }
        else
        {
            if (depth < input.Length / 2)
            {
                input[index] = '(';
                AddBracket(depth + 1, index + 1);
                input[index] = '?';

                
            }
            if (depth > 0)
            {
                input[index] = ')';
                AddBracket(depth - 1, index + 1);
                input[index] = '?';
                
            }
        }

    }
    static void Main(string[] args)
    {
        int index = 0;
        string s = Console.ReadLine();
        input = s.ToCharArray();
        int depth = 0;

        AddBracket(0, index);
        Console.WriteLine(counter);
    }
}

